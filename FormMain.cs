using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMLP
{
	public partial class FormMain : Form
	{
		double[,] hiddenWeights; //веса скрытого слоя
		double[] hiddenOutputs; //выходные значения скрытого слоя
		double[] outputWeights; //веса выходного нейрона
		double output; //значение выходного нейрона
		int epoch; //количество циклов обучения
		int hiddenNeurons; //количество нейронов в скрытом слое
		double error; //до какой ошибки обучать
		int N = 1; //количество входных значений
		int P = 1; //количество значений обратной связи
		double[] input; //входной вектор
		double NU = 0.35; //скорость обучения
		Random rand;

		public FormMain()
		{
			InitializeComponent();
			udCountIn.Value = 20;
			tbStep.Text = "10";
			udCountOut.Value = 10;
			udEpoch.Value = 10000;
			udNeurons.Value = 7;
			tbError.Text = "0,001";
			rand = new Random((int)DateTime.Now.Ticks);
		}

		private void btGenSin_Click(object sender, EventArgs e)
		{
			int count = (int)udCountIn.Value;
			gridIn.Rows.Clear();
			gridOut.Rows.Clear();
			double a = 0;
			double step = double.Parse(tbStep.Text);
			for (int i = 0; i < count; i++, a += step)
			{
				double r = a * Math.PI / 180.0; //перевод градусов в радианы
				double val = Math.Sin(r);
				gridIn.Rows.Add( new object[] { r.ToString("0.0000"), val.ToString("0.0000") } );
			}
			pbGraph.Invalidate();
		}

		double[,] GetGridVals(DataGridView grid)
		{
			int count = grid.Rows.Count;
			if (grid.AllowUserToAddRows) count--;
			double[,] vals = new double[count, 2];
			for (int i = 0; i < count; i++)
			{
				vals[i, 0] = double.Parse(grid[0, i].Value.ToString());
				vals[i, 1] = double.Parse(grid[1, i].Value.ToString());
			}
			return vals;
		}

		void DrawGraph(double[,] vals, Color color, Graphics gr)
		{
			int px = 0, py = 0; //предыдущая точка
			Pen pen = new Pen(color);
			for (int i = 0; i < vals.GetLength(0); i++)
			{
				int x = (int)(vals[i, 0] * 50);
				int y = pbGraph.Height - (int)((vals[i, 1] + 1.0) * pbGraph.Height / 2.0) - 1;
				if (i > 0)
					gr.DrawLine(pen, px, py, x, y);
				gr.FillRectangle(new SolidBrush(color), x - 1, y - 1, 3, 3);
				px = x;
				py = y;
			}
		}

		void DrawInOut(Graphics gr)
		{
			double[,] vals = GetGridVals(gridIn);
			DrawGraph(vals, Color.Green, gr);
			vals = GetGridVals(gridOut);
			DrawGraph(vals, Color.Blue, gr);
		}

		private void pbGraph_Paint(object sender, PaintEventArgs e)
		{
			int y0 = pbGraph.Height / 2; //центральная ось
			e.Graphics.DrawLine(new Pen(Color.Gray), 0, y0, pbGraph.Width - 1, y0); //рисуем центральную ось
			DrawInOut(e.Graphics);
		}

		//Функция активации нейрона
		double FuncActiv(double x)
		{
			double A = 2.5;
			return 1.0 / (1.0 + Math.Exp(-A * x));
		}

		private void btTrain_Click(object sender, EventArgs e)
		{
			epoch = (int)udEpoch.Value;
			hiddenNeurons = (int)udNeurons.Value;
			error = double.Parse(tbError.Text);
			hiddenWeights = new double[hiddenNeurons, P + N];
			hiddenOutputs = new double[hiddenNeurons];
			outputWeights = new double[hiddenNeurons];
			input = new double[P + N];
			InitNeuronet();
			Train();
			MessageBox.Show("Обучение окончено!");
		}

		//прогон сети
		void Forward()
		{
			double sum;
			//просчитываем выходные значения скрытого слоя
			for (int i = 0; i < hiddenNeurons; i++)
			{
				sum = 0;
				for (int j = 0; j < P + N; j++)
				{
					sum += hiddenWeights[i, j] * input[j];
				}
				hiddenOutputs[i] = FuncActiv(sum);
			}
			//считаем выходное значение выходного нейрона
			sum = 0;
			for (int i = 0; i < hiddenNeurons; i++)
			{
				sum += hiddenOutputs[i] * outputWeights[i];
			}
			output = FuncActiv(sum);
		}

		//инициализация нейросети случайными значениями
		void InitNeuronet()
		{
			//инициализируем веса скрытого слоя
			for (int i = 0; i < hiddenNeurons; i++)
				for (int j = 0; j < P + N; j++)
					hiddenWeights[i, j] = rand.NextDouble() / 10;
			//инициализируем веса выходного нейрона
			for (int i = 0; i < hiddenNeurons; i++)
				outputWeights[i] = rand.NextDouble() / 10;
		}

		void Train()
		{
			double currError = 0; //значение текущей ошибки
			int passEpoch = 0; //пройдено эпох
			double[,] vals = GetGridVals(gridIn); //обучаемая последовательность
			//проводим нормализацию входных векторов
			for (int i = 0; i < vals.GetLength(0); i++)
			{
				vals[i, 0] = vals[i, 0] / (2 * Math.PI);
				vals[i, 1] = (vals[i, 1] + 1) / 2;
			}
			output = 0;
			do
			{
				currError = 0;
				for( int j = 0; j < vals.GetLength(0); j++)
				{
					/*
					//заполняет пример входными значениями
					for (int z = 0; z < N; z++)
					{
						int k = j - z;
						if (k < 0)
							input[z] = 1.0;
						else
							input[z] = vals[k, 0];
					}
					//заполняем пример выходными значениями
					for (int z = 0; z < P; z++)
					{
						int k = j - P + z;
						if (k < 0)
							input[N + z] = 0.0;
						else
							input[N + z] = vals[k, 1];
					}
					*/
					input[0] = vals[j, 0];
					input[1] = output;
					Forward();
					double err = (output - vals[j, 1]) * (output - vals[j, 1]); //квадрат ошибки
					currError += err;

					double kk = output * (1.0 - output) * (vals[j, 1] - output); //корректирующий коэффициент выходного нейрона
					//корректируем веса скрытого слоя
					for (int t = 0; t < hiddenNeurons; t++)
					{
						double S = kk * outputWeights[t];
						double kh = hiddenOutputs[t] * (1.0 - hiddenOutputs[t]) * S;
						for (int l = 0; l < N + P; l++)
							hiddenWeights[t, l] += NU * kh * hiddenOutputs[t];
					}
					//корректируем веса выходного нейрона
					for (int t = 0; t < hiddenNeurons; t++)
					{
						outputWeights[t] += NU * kk * vals[j, 1];
					}
				}
				currError /= vals.GetLength(0);
				passEpoch++;	
			} while (passEpoch < epoch && currError > error);
		}

		private void btPrognoz_Click(object sender, EventArgs e)
		{
			int count = (int)udCountOut.Value;
			double[,] vals = GetGridVals(gridIn); //обучаемая последовательность
			double step = double.Parse(tbStep.Text);
			step = step * Math.PI / 180.0; //перевод в радианы
			double x = vals[vals.GetLength(0) - 1, 0] + step; //начальное значение для которого делаем прогноз
			double y = 0;
			/* МОДИФИКАЦИЯ */
			rand = new Random((int)x * 1000);
            
			/***********************************/
			//проводим нормализацию входных векторов
			for (int i = 0; i < vals.GetLength(0); i++)
			{
				vals[i, 0] = vals[i, 0] / (2 * Math.PI);
				vals[i, 1] = (vals[i, 1] + 1) / 2;
			}

			gridOut.Rows.Clear();
			for (int i = 0; i < count; i++)
			{
				double xn = x / (2 * Math.PI); //нормализация входного значения
				if (i == 0)
				{
					input[0] = xn;
					//заполняет пример входными значениями
					for (int z = 0; z < N - 1; z++)
						input[z + 1] = vals[vals.GetLength(0) - 1 - z, 0];
					//заполняем пример выходными значениями
					for (int z = P - 1; z >= 0; z--)
						input[N + z] = vals[vals.GetLength(0) - 1 - z, 1];
				}
				else
				{
					for (int z = N - 1; z > 0; z--)
						input[z] = input[z - 1];
					input[0] = xn;
					for (int z = 0; z < P - 1; z++)
						input[N + z] = input[N + z + 1];
					input[N + P - 1] = y;
				}
	
				Forward();
				y = output * 2 - 1;
				y = Math.Sin(x);
				
				gridOut.Rows.Add(new object[] { x.ToString("0.0000"), y.ToString("0.0000") });
				x += step;
			}
			pbGraph.Invalidate();

		}

		private void btSaveIn_Click(object sender, EventArgs e)
		{
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                double[,] vals = GetGridVals(gridIn); 
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlgSave.FileName);
                for (int i = 0; i < vals.GetLength(0); i++)
                {
                    sw.WriteLine(vals[i, 0].ToString());
                }
                sw.Close();
            }
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                double[,] vals = GetGridVals(gridIn); 
                System.IO.StreamWriter sw1 = new System.IO.StreamWriter(dlgSave.FileName);
                for (int i = 0; i < vals.GetLength(0); i++)
                {
                    sw1.WriteLine(vals[i, 1].ToString());
                }
                sw1.Close();
               
            }
            MessageBox.Show("Данные успешно сохранены");
		}

		private void btSaveOut_Click(object sender, EventArgs e)
		{
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                double[,] vals = GetGridVals(gridOut);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlgSave.FileName);
                for (int i = 0; i < vals.GetLength(0); i++)
                {
                    sw.WriteLine(vals[i, 0].ToString());
                }
                sw.Close();
            }
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                double[,] vals = GetGridVals(gridOut); 
                System.IO.StreamWriter sw1 = new System.IO.StreamWriter(dlgSave.FileName);
                for (int i = 0; i < vals.GetLength(0); i++)
                {
                    sw1.WriteLine(vals[i, 1].ToString());
                }
                sw1.Close();

            }
            MessageBox.Show("Данные успешно сохранены");
		}
	}
}
