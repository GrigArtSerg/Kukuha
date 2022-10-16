﻿using System;
using System.Windows.Forms;
using System.Media;
using System.IO;

// чтобы жрать ещё меньше ресов, надо КД таймера сделать раз в минуту, а для синхронизации при запуске КД делать соотв, чтобы синхронилось на 00мин

namespace Kukuha
{
    public partial class Form1 : Form
    {
        //путь к саундам
        string timeMainPath = Directory.GetCurrentDirectory() + @"\TimeSounds\sp"; 
        string randomMainPath = Directory.GetCurrentDirectory() + @"\RandomSounds\sp"; 

        //таймер типо
        Timer timer01 = new Timer();

        //Рандомазер
        Random rnd = new Random();

        //звук рандомный
        SoundPlayer sayRandom = new SoundPlayer();

        //звук таймера
        SoundPlayer sayTime = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {

            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(timer1_Tick);
            timer01.Start();

        }

        //Таймер по КД раз в секунду перерисовывает текст
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Записываем время
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");

            //Точное время (минуты 00, секунды 00)
            if (DateTime.Now.Minute.ToString("00") == "00" && DateTime.Now.Second.ToString("00") == "00")
            {
                playTheTime(DateTime.Now.Hour.ToString("00"));
            }

            //Добавочная рандомная фигня (минуты 00, секунды 03)
            if (DateTime.Now.Minute.ToString("00") == "00" && DateTime.Now.Second.ToString("00") == "03")
            {
                playTheRandomAction();
            }

        }

        //Воспроизводим время
        void playTheTime(string hoursNow)
        {
            
            string path = timeMainPath + hoursNow + ".wav";

            if (Int32.Parse(hoursNow) >= 48)
            {

                int hh = Int32.Parse(hoursNow) - 48;
                hoursNow = hh.ToString("00");
                path = timeMainPath + hoursNow + ".wav";

            } else if (Int32.Parse(hoursNow) >= 24)
            {

                int hh = Int32.Parse(hoursNow) - 24;
                hoursNow = hh.ToString("00");
                path = timeMainPath + hoursNow + ".wav";

            }             

            sayTime.SoundLocation = path;
            sayTime.Play();

        }

        //Добавляем немного рандома
        void playTheRandomAction() /*actionNow Надо юзать как ориентир для фраз или нахер?*/
        {
            int filesNumber = System.IO.Directory.GetFiles(randomMainPath.Substring(0, randomMainPath.Length - 3)).Length; // количество файлов в папке. путь минус последние три символа - путь к папке

            string numOfFile = rnd.Next(filesNumber).ToString("00"); /*рандом из количества файлов*/

            //fixme
            Console.WriteLine(numOfFile  + " of " + filesNumber);

            string path = randomMainPath + "d" + numOfFile + ".wav";

            sayRandom.SoundLocation = path;
            sayRandom.Play();

        }

        public Form1()
        {
            InitializeComponent();
        }

        #region Кнопачке
        private void testTimeBtn_Click_1(object sender, EventArgs e)
        {
            string tempText = label1.Text;

            tempText = tempText.Substring(0, tempText.Length - 3);

            playTheTime(tempText);

        }


        private void testRandomBtn_Click_1(object sender, EventArgs e)
        {

            playTheRandomAction();
        }
        #endregion
    }
}