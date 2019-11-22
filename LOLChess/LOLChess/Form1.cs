using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLChess
{
	public partial class Form1 : Form
	{
        //Champion champion;
        //Champion[] champions = new Champion[50]; // 모든 챔피언 배열
        //List<Champion> deck = new List<Champion>(); // 배치한 챔피언 덱 리스트

        public Form1()
		{
			InitializeComponent();
          
            pictureBox52.AllowDrop = true;
            pictureBox53.AllowDrop = true;
            pictureBox54.AllowDrop = true;
            pictureBox55.AllowDrop = true;
            pictureBox56.AllowDrop = true;
            pictureBox57.AllowDrop = true;
            pictureBox58.AllowDrop = true;
            pictureBox59.AllowDrop = true;
            pictureBox60.AllowDrop = true;
            pictureBox61.AllowDrop = true;
            pictureBox62.AllowDrop = true;
            pictureBox63.AllowDrop = true;
            pictureBox64.AllowDrop = true;
            pictureBox65.AllowDrop = true;
            pictureBox66.AllowDrop = true;
            pictureBox67.AllowDrop = true;
            pictureBox68.AllowDrop = true;
            pictureBox69.AllowDrop = true;
            pictureBox70.AllowDrop = true;
            pictureBox71.AllowDrop = true;
            pictureBox72.AllowDrop = true;
            pictureBox73.AllowDrop = true;
            pictureBox74.AllowDrop = true;
            pictureBox75.AllowDrop = true;
            pictureBox76.AllowDrop = true;
            pictureBox77.AllowDrop = true;
            pictureBox78.AllowDrop = true;
            pictureBox79.AllowDrop = true;		
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "LOLChess Simulator";
			label1.Text = "\n\n 챔피언을\n\n 배치하면\n\n 시너지가\n\n 활성화됩니다.";
			label2.Text = "※럭스, 키아나를\n처음 배치할 때\n원소가 무작위로\n지정됩니다.";

			Bitmap bitmap = new Bitmap(new Bitmap(Properties.Resources.icon), 25, 25);
			this.Cursor = new Cursor(bitmap.GetHicon());
		}

		// 챔피언, 아이템 마우스 다운
		private void Champion_MouseDown(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			pictureBox.Select();
			pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
		}

		// 배치칸 마우스 다운
		private void Arrangement_MouseDown(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			pictureBox.Select();
			pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move);
			pictureBox.Image = null;
		}

		// 배치칸 드래그엔터
		private void Arrangement_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Bitmap))
			{
				if (e.AllowedEffect == DragDropEffects.Copy)
					e.Effect = DragDropEffects.Copy;
				else if (e.AllowedEffect == DragDropEffects.Move)
					e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		// 배치칸 드래그드롭
		private void Arrangement_DragDrop(object sender, DragEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;           
            pictureBox.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

		// 배치칸에 드래그오버했을 때 백그라운드색 바뀜
        private void Arrangement_DragOver(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pictureBox.BackColor = Color.DarkSlateGray;
            }
        }

		// 배치칸에서 드래그리브할 때 백그라운드색 원래대로
        private void Arrangement_DragLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.Black;       
        }

		// 챔피언, 아이템, 시너지에 마우스오버했을 때 설명 띄우기
		private void Champion_MouseHover(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			//toolTip1.SetToolTip(pictureBox, "kk");		
		}

        //private void AddChampions()
        //{
        //    champions[0] = new Aatrox("Aatrox", "빛", "검사");
        //    champions[1] = new Nami("Nami", "바다", "신비술사");
        //}

        //public void CheckElement(List<Champion> deck)
        //{
        //    int crystal = 0; // 수정
        //    int desert = 0; // 사막
        //    int electric = 0; // 전기
        //    int glacial = 0; // 빙하
        //    int inferno = 0; // 지옥불
        //    int light = 0; // 빛
        //    int mountain = 0; // 대지
        //    int ocean = 0; // 바다
        //    int poison = 0; // 맹독
        //    int shadow = 0; // 그림자
        //    int steel = 0; // 강철
        //    int wind = 0; // 바람
        //    int woodland = 0; // 숲

        //    for (int i = 0; i < deck.Count; i++)
        //    {
        //        if (deck[i].GetElement == "빛")
        //        {
        //            label1.Text += "빛 : " + light; 
        //            light++;
        //        }
        //        if (deck[i].GetElement == "바다")
        //        {
        //            label1.Text += "바다 : " + ocean;
        //            ocean++;
        //        }
        //    }
        //}

    }
}
