using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_str_arr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[][] arr = new string[10][];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = new string[1]; // 각각의 1차원 배열 초기화
            }

            arr[0][0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            arr[1][0] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            arr[2][0] = "질서 있는 퇴장".Contains("퇴").ToString();
            arr[3][0] = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            arr[4][0] = "삼성 갤럭시".Insert(2, " 애플");
            arr[5][0] = "오늘은 왠지 더 배고프다".Remove(7, 2); 
            arr[6] = "이름, 나이, 전화번호".Split(',');
            arr[7][0] = "우리 나라 만세".Substring(3, 2);


            textBox1.Text = "";
            textBox1.Text += arr[0][0] + "\r\n";
            textBox1.Text += arr[1][0] + "\r\n";
            textBox1.Text += arr[2][0] + "\r\n";
            textBox1.Text += arr[3][0] + "\r\n";
            textBox1.Text += arr[4][0] + "\r\n";
            textBox1.Text += arr[5][0] + "\r\n";
            string result = String.Join("/", arr[6]);
            textBox1.Text += result + "\r\n";
            textBox1.Text += arr[7][0] + "\r\n";
            textBox1.Text += arr[8][0] + "\r\n";
            textBox1.Text += arr[9][0] + "\r\n";




        }
    }
}
