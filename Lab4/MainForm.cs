using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace Lab4
{
    public partial class MainForm : Form
    {
        double[] FValues;
        double[] PredictedValues;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeFuncDataGridViewSize();
            SetStandardGridData();
            DataTable dt = new DataTable();          
        }

        private Vector<double> GetSolvedSystem(double[,] coefficients, double[] constants)
        {
            Vector<double> solution;
            if (coefficients.GetLength(0) != coefficients.GetLength(1)&& coefficients.GetLength(0) > coefficients.GetLength(1))
            {
                double[,] squareCoefficients = CreateSquareCoefficients(coefficients);
                double[] squareConstants = CreateSquareConstants(coefficients, constants);
                Matrix<double> coefficientsMatrix = Matrix<double>.Build.DenseOfArray(squareCoefficients);
                Vector<double> constantsVector = Vector<double>.Build.DenseOfArray(squareConstants);
                solution = coefficientsMatrix.Solve(constantsVector);
            }
            else if (coefficients.GetLength(0) < coefficients.GetLength(1))
            {
                return null;
            }
            else
            {
                Matrix<double> coefficientsMatrix = Matrix<double>.Build.DenseOfArray(coefficients);
                Vector<double> constantsVector = Vector<double>.Build.DenseOfArray(constants);
                solution = coefficientsMatrix.Solve(constantsVector);
            }
            return solution;
        }

        private bool CheckForEmptyValuesInDataGridCells()
        {
            for (int i = 0; i < funcDataGridView.RowCount; i++)
            {
                if (String.IsNullOrEmpty(funcDataGridView.Rows[i].Cells[1].Value.ToString()))
                    return true;
            }
            return false;
        }

        private double[] GetFValues()
        {
            if (CheckForEmptyValuesInDataGridCells()||funcDataGridView.RowCount==0)
                return null;
            double[] F = new double[funcDataGridView.RowCount];
            for (int i = 0; i < F.Length; i++)
            {
                F[i] = Convert.ToDouble(funcDataGridView.Rows[i].Cells[1].Value);
            }
            return F;
        }

        private void SetStandardGridData()
        {
            funcDataGridView.Rows[0].Cells[1].Value = 10;
            funcDataGridView.Rows[1].Cells[1].Value = 15;
            funcDataGridView.Rows[2].Cells[1].Value = 13;
            funcDataGridView.Rows[3].Cells[1].Value = 19;
            funcDataGridView.Rows[4].Cells[1].Value = 14;
            funcDataGridView.Rows[5].Cells[1].Value = 18;
            funcDataGridView.Rows[6].Cells[1].Value = 17;
            funcDataGridView.Rows[7].Cells[1].Value = 11;
        }


        private double[] CreateSquareConstants(double[,] coefficients, double[] constants)
        {
            double[] squareConstants = new double[coefficients.GetLength(1)];
            int equationsCount = 0;
            for (int i = 0; i < squareConstants.Length; i++)
            {
                squareConstants[i] = FindSumOfColumnForConstant(coefficients, constants, equationsCount);
                equationsCount++;
            }
            return squareConstants;
        }

        private double[,] CreateSquareCoefficients(double[,] coefficients)
        {
            int equationsCount = 0;

            double[,] squareCoefficients = new double[coefficients.GetLength(1), coefficients.GetLength(1)];

            for (int i = 0; i < squareCoefficients.GetLength(0); i++)
            {
                for (int j = 0; j < squareCoefficients.GetLength(1); j++)
                {
                    squareCoefficients[i, j] = FindSumOfColumnForCoefficient(coefficients, j, equationsCount);
                }
                equationsCount++;
            }

            return squareCoefficients;
        }
        private int GetNumberOfEquations()
        {
            int number = 0;
            for (int i = 0; i < funcDataGridView.Rows.Count; i++)
            {
                if (i + 2 != funcDataGridView.Rows.Count)
                    number++;
                else
                    break;
            }
            return number;
        }
        private double[,] GetCoefficientsOfPredictionModel(double[] FValues)
        {
            double[,] coefficients = new double[GetNumberOfEquations(), 9];
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                double x1 = FValues[i];
                double x2 = FValues[i + 1];
                coefficients[i, 0] = 1;
                coefficients[i, 1] = x1;
                coefficients[i, 2] = x2;
                coefficients[i, 3] = x1 * x2;
                coefficients[i, 4] = x1 * x1;
                coefficients[i, 5] = x2 * x2;
                coefficients[i, 6] = (x1 * x1) * x2;
                coefficients[i, 7] = x1 * (x2 * x2);
                coefficients[i, 8] = (x1 * x1) + (x2 * x2);
            }
            return coefficients;
        }

        private double[] GetConstants()
        {
            double[] constants = new double[GetNumberOfEquations()];
            for (int i = 0; i < constants.Length; i++)
            {
                constants[i] = Convert.ToDouble(funcDataGridView.Rows[i + 2].Cells[1].Value);
            }
            return constants;
        }
        private double[,] GetCoefficients(double[] FValues)
        {
            if (int.TryParse(numberOfCoefficientsTextBox.Text, out int res))
            {
                double[,] coefficients = new double[GetNumberOfEquations(), res];
                double[,] coefficientsOfPredictionModel = GetCoefficientsOfPredictionModel(FValues);
                for (int i = 0; i < coefficients.GetLength(0); i++)
                {
                    for (int j = 0; j < coefficients.GetLength(1); j++)
                    {
                        coefficients[i, j] = coefficientsOfPredictionModel[i, j];
                    }
                }
                return coefficients;
            }
            else
                return null;
        }

        private double FindSumOfColumnForConstant(double[,] coefficients, double[] constants, int equationsCount)
        {
            double sum = 0;
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                sum += constants[i] * coefficients[i, equationsCount];
            }
            return sum;
        }

        private double FindSumOfColumnForCoefficient(double[,] coefficients, int column, int equationsCount)
        {
            double sum = 0;
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                sum += coefficients[i, column] * coefficients[i, equationsCount];
            }
            return sum;
        }

        private void ChangeFuncDataGridViewSize()
        {
            if (int.TryParse(numberOfStudyingElementsTextBox.Text, out int res))
            {
                funcDataGridView.Rows.Clear();
                int rowsCount = funcDataGridView.Rows.Count;
                if (funcDataGridView.Rows.Count < res)
                {
                    for (int i = rowsCount + 1; i <= res; i++)
                    {
                        funcDataGridView.Rows.Add();
                    }
                    for (int i = rowsCount; i < funcDataGridView.Rows.Count; i++)
                    {
                        funcDataGridView.Rows[i].Cells[0].Value = i + 1;
                    }
                }
                else
                {
                    for (int i = res + 1; i <= rowsCount; i++)
                    {
                        funcDataGridView.Rows.RemoveAt(0);
                    }
                    for (int i = 0; i < funcDataGridView.Rows.Count; i++)
                    {
                        funcDataGridView.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
        }

        

        private double GetPredictedFValue(Vector<double> solvedSystem, double firstPrevFValue, double secondPrevFValue)
        {
            double predictedFValue = 0;
            double[] coefficients = new double[9];
            double x1 = firstPrevFValue;
            double x2 = secondPrevFValue;
            coefficients[0] = 1;
            coefficients[1] = x1;
            coefficients[2] = x2;
            coefficients[3] = x1 * x2;
            coefficients[4] = x1 * x1;
            coefficients[5] = x2 * x2;
            coefficients[6] = (x1 * x1) * x2;
            coefficients[7] = x1 * (x2 * x2);
            coefficients[8] = (x1 * x1) + (x2 * x2);
            for (int i = 0; i < solvedSystem.Count; i++)
            {
                predictedFValue += solvedSystem[i] * coefficients[i];
            }
            return predictedFValue;
        }

        private double[,] GetPredictedValues(Vector<double> solvedSystem, double[] FValues, int startPoint, int numberOfElementsToPredict)
        {
            double[,] predictedValues = new double[numberOfElementsToPredict,2];
            int endPoint = startPoint + numberOfElementsToPredict;
            int j = 0;
            for (int i = startPoint-1; i < endPoint-1; i++)
            {
                predictedValues[j, 0] = i;
                predictedValues[j,1] = GetPredictedFValue(solvedSystem, FValues[i-2], FValues[i-1]);
                j++;
            }
            return predictedValues;
        }

        private void numberOfStudyingElementsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfStudyingElementsTextBox.Text, out int res))
                ChangeFuncDataGridViewSize();
            else
                numberOfStudyingElementsTextBox.Text = "";
        }

        private void setStandardDataButton_Click(object sender, EventArgs e)
        {
            numberOfStudyingElementsTextBox.Text = 8.ToString();
            numberOfElementsToPredictTextBox.Text = 2.ToString();
            startPointOfStudyTextBox.Text = 3.ToString();
            numberOfCoefficientsTextBox.Text = 4.ToString();
            ChangeFuncDataGridViewSize();
            SetStandardGridData();
        }

        private void numberOfCoefficientsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfCoefficientsTextBox.Text, out int res))
            {
                if (res > 8)
                {
                    numberOfCoefficientsTextBox.Text = 9.ToString();
                }
            }
            else
            {
                numberOfCoefficientsTextBox.Text = "";
            }
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            
            FValues = GetFValues();
            if(FValues==null)
            {
                MessageBox.Show("Неправильні значення розподілу");
                return;
            }
            double[,] coefficients = GetCoefficients(FValues);
            if (coefficients == null)
                return;
            double[] constants = GetConstants();
            Vector<double> solvedSystem = GetSolvedSystem(coefficients, constants);
            if (solvedSystem == null)
            {
                MessageBox.Show("Неправильне співвідношення кількості коефіцієнтів та кількості елементів навчання");
                return;
            }
            if(!(int.Parse(startPointOfStudyTextBox.Text)>2&&(int.Parse(startPointOfStudyTextBox.Text)+int.Parse(numberOfElementsToPredictTextBox.Text))<FValues.Length))
            {
                MessageBox.Show("Неправильні початкова точка або/та кількість елементів прогнозування");
                return;
            }
            double[,] predictedValues = GetPredictedValues(solvedSystem,FValues,int.Parse(startPointOfStudyTextBox.Text),int.Parse(numberOfElementsToPredictTextBox.Text));
            DataTable solvedSystemTable = new DataTable();
            DataTable predictedValuesTable = new DataTable();
            solvedSystemTable.Columns.Add();
            solvedSystemTable.Columns.Add();
            predictedValuesTable.Columns.Add("Вхідні");
            predictedValuesTable.Columns.Add("Зпрогнозовані");
            predictedValuesTable.Columns.Add("Похибка");
            for (int i = 0; i < solvedSystem.Count; i++)
            {
                solvedSystemTable.Rows.Add();
                solvedSystemTable.Rows[i][0] ="a"+i;
                solvedSystemTable.Rows[i][1] = solvedSystem[i].ToString();
            }
            
            for (int i = 0; i < FValues.Length; i++)
            {
                predictedValuesTable.Rows.Add();
                predictedValuesTable.Rows[i][0] = FValues[i].ToString();
                predictedValuesTable.Rows[i][1] = i >= Convert.ToInt32(predictedValues[0, 0]) && i <= Convert.ToInt32(predictedValues[predictedValues.GetLength(0)-1, 0]) ? predictedValues[i - Convert.ToInt32(predictedValues[0, 0]), 1].ToString() : "-";
                predictedValuesTable.Rows[i][2] = double.TryParse(predictedValuesTable.Rows[i][1].ToString(), out double res) ? Math.Abs(double.Parse(predictedValuesTable.Rows[i][0].ToString()) - res).ToString() : "-";
                
            }
            PredictedValues = new double[FValues.Length];
            for (int i = 0; i < PredictedValues.GetLength(0); i++)
            {
                PredictedValues[i] = i >= Convert.ToInt32(predictedValues[0, 0]) && i <= Convert.ToInt32(predictedValues[predictedValues.GetLength(0) - 1, 0]) ? predictedValues[i - Convert.ToInt32(predictedValues[0, 0]), 1] : double.NaN;
            }
            solvedSystemDataGridView.DataSource = solvedSystemTable;
            predictedValuesDataGridView.DataSource = predictedValuesTable;
            solvedSystemDataGridView.Columns[0].Width = 40;
            solvedSystemDataGridView.Visible = true;
            predictedValuesDataGridView.Visible = true;
            coefficientsValuesLabel.Visible = true;
            compareStatsLabel.Visible = true;

        }

        private void numberOfElementsToPredictTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(numberOfElementsToPredictTextBox.Text, out int res))
            {
                numberOfElementsToPredictTextBox.Text = "";
            }
        }

        private void startPointOfStudyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(startPointOfStudyTextBox.Text, out int res))
            {
                startPointOfStudyTextBox.Text = "";
            }
        }

        private void makeChartButton_Click(object sender, EventArgs e)
        {
            if (PredictedValues != null)
            {
                if (Application.OpenForms["Chart"] == null)
                {
                    new Chart(FValues, PredictedValues).Show();
                }
                else
                {
                    Application.OpenForms["Chart"].Close();
                    new Chart(FValues, PredictedValues).Show();
                }
            }
            else
            {
                MessageBox.Show("Для побудови графіку потрібно зпрогнозувати дані");                
            }
        }
    }
}
