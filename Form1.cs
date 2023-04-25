using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab4._1
{
    public partial class Form1 : Form
    {
        private Storage storage = new Storage(10); //хранилище из 10 элементов
        private bool chooseCircle = false; //проверка на нажатие на круг или на пустое место


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) //событие Paint
        {
            Graphics g = e.Graphics; //обьект для рисования
            for (int i = 0; i < storage.GetCount(); i++)
                storage.GetObject(i).Draw(g); //рисует круг 
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e) //событие при нажатие на pictureBox
        {
            if (CheckDown()) //проверка на нажатие ctrl
            {
                if (checkBox2.Checked == true)
                {
                    for (int i = 0; i < storage.GetCount(); i++) //проходимся по каждому элементу хранилища
                    {
                        var shape = storage.GetObject(i); //сохраняем в переменную i обьект 
                        if (shape.CheckCollision(e.X, e.Y)) //проверка на нажатие круга
                        {

                            if (shape.selected)
                            {
                                shape.UnSelect();
                                chooseCircle = true;
                                break;
                            }
                            else
                            {
                                shape.Select();
                                chooseCircle = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < storage.GetCount(); i++) //проходимся по каждому элементу хранилища
                    {
                        var shape = storage.GetObject(i); //сохраняем в переменную i обьект 
                        if (shape.CheckCollision(e.X, e.Y)) //проверка на нажатие круга
                        {
                            if (shape.selected) //если круг помеченный
                            {
                                shape.UnSelect(); //то делаем его не помеченным
                            }
                            else
                            {
                                shape.Select(); //иначе делаем его помеченным

                            }
                            chooseCircle = true; // если нажали на круг
                        }
                    }
                }
            }
            else //если без нажатия на ctrl
            {
                int saveI = 0; //сохраняет номер элемента который должен быть единственным помеченным
                for (int i = 0; i < storage.GetCount(); i++)
                {
                    var shape = storage.GetObject(i); //сохраняет в переменную обьект 
                    if (shape.CheckCollision(e.X, e.Y)) //проверка на нажатие внутри круга
                    {
                        shape.Select(); //помечает круг 
                        saveI = i; //сохраняет его номер
                        chooseCircle = true; // нажали на круг
                    }
                }

                for (int i = 0; i < storage.GetCount(); i++)
                {
                    var shape = storage.GetObject(i);
                    if (i == saveI) // если мы нашли помеченный обьект
                    {
                        continue; // пропускаем его
                    }
                    else
                    {
                        shape.UnSelect(); //остальные делаем помеченными
                    }
                }
            }

            if (chooseCircle == false) // если не нажали на круг 
            {
                Circle circle = new Circle(e.X, e.Y, 75); //создаем круг
                storage.AddObj(circle); //добавляем в хранилище
                countLb.Text = "Objects in storage: " + Convert.ToString(storage.GetCount());

                storage.GetObject(storage.GetCount() - 1).Select(); //делаем новый созданый круг помеченным

                for (int i = 0; i < storage.GetCount() - 1; i++) //все остальные не помеченные
                    storage.GetObject(i).UnSelect();
            }

            pictureBox.Refresh(); //вызывает событие paint
            chooseCircle = false; //сбрасывает
        }

        private bool CheckDown() //проверка на нажатие ctrl
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void Check_KeyDown()
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                checkBox1.Checked = true;
            }
        }

        private void deleteBtn_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < storage.GetCount(); ++i)
                if (storage.GetObject(i).selected) //если помеченный
                {
                    storage.DeleteObject(i); //удаляем его
                    i--;
                }

            if (storage.GetCount() != 0) // если не пусто, то
                storage.GetObject(storage.GetCount() - 1).Select(); //помечаем последний элемент 

            countLb.Text = "Objects in storage: " + Convert.ToString(storage.GetCount());
            pictureBox.Refresh();
        }

        private void checkBox1_KeyUp(object sender, KeyEventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                checkBox1.Checked = true;
            }
        }

    }
}