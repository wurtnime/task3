using ProjectN2;
using System;
using System.Buffers;
using System.Data;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа N4");
            Console.WriteLine("1 - 30");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    double x = 3.5;
                    double b = 0.4;

                    Task1 task1 = new Task1(b, x);
                    task1.G1();
                    break;
                case 2:
                    double x2 = 1.3;
                    double k2 = 4;

                    Task2 task2 = new Task2(k2, x2);
                    task2.F2();
                    break;
                case 3:
                    double x3 = 2.1;
                    double p3 = 1;

                    Task3 task3 = new Task3(x3, p3);
                    task3.U3();
                    break;

                case 4:
                    double x4 = 2.1;
                    double t4 = -6;

                    Task4 task4 = new Task4(x4, t4);
                    task4.G4();
                    break;

                case 5:
                    double t5 = 4.1;
                    double p5 = 3;

                    Task5 task5 = new Task5(t5, p5);
                    task5.G1();
                    break;

                case 6:
                    double m6 = 2;
                    double x6 = 1.1;

                    Task6 task6 = new Task6(m6, x6);
                    task6.G1();
                    break;

                case 7:
                    double k7 = 8.2;
                    double x7 = 5;

                    Task7 task7 = new Task7(k7, x7);
                    task7.G1();
                    break;

                case 8:
                    double b8 = 2.2;
                    double c8 = 3.7;

                    Task8 task8 = new Task8(b8, c8 );
                    task8.G1();
                    break;
                
                case 9:
                    double k9 = 1;
                    double m9 = 1.8;
                    
                    Task9 task9 = new Task9(k9, m9);
                    task9.G1();
                    break;

                case 10:
                    double b10 = 1.3;
                    double x10 = 2.8;
                    Task10 task10 = new Task10(x10, b10);
                    task10.G1();
                    break;
                
                case 11:
                    double b11 = 7;
                    double x11 = 2;

                    Task11 task11 = new Task11(x11, b11);
                    task11.G1();
                    break;

                case 12:
                    double q12 = 2;
                    double b12 = 1.8;

                    Task12 task12 = new Task12(q12, b12);
                    task12.G1();
                    break;

                case 13:
                    double x13 = 1.9;
                    double a13 = -0.9;
                    
                    Task13 task13 = new Task13(x13,a13);
                    task13.G1();
                    break;

                case 14:
                    double k14 = 6;
                    double b14 = 3.4;
                    


                    Task14 task14 = new Task14(b14, k14);
                    task14.G1();
                    break;

                case 15:
                    double a15 = 5.5;
                    double p15 = 4;
                    
                    Task15 task15 = new Task15(p15, a15);
                    task15.G1();
                    break;

                case 16:
                    double x16, c16; ;
                    x16 = 8.52; c16 = 9;
                    Task16 task16 = new Task16(c16, x16);
                    task16.F2();
                    break;

                case 17:
                    double x17, t17; ;
                    x17 = 0.9; t17 = 2;
                    Task17 task17 = new Task17(x17, t17);
                    task17.F2();
                    break;

                case 18:
                    double x18, b18; ;
                    x18 = -8; b18 = 9.5;
                    Task18 task18 = new Task18(x18, b18);
                    task18.F2();
                    break;

                case 19:
                    double x19, a19;
                    x19 = 4; a19 = 3.7;

                    Task19 task19 = new Task19(x19, a19);
                    task19.F2();
                    break;

                case 20:
                    double x20, p20;
                    x20 = 1.4; p20 = 1.6;


                    Task20 task20 = new Task20(p20, x20);
                    task20.F2();
                    break;

                case 21:
                    double n21, b21;
                    n21 = 8.1; b21 = 1.6;
                    Task21 task21 = new Task21(n21, b21);
                    task21.F2();
                    break;

                case 22:
                    double m22, p22;
                    m22 = 5.7; p22 = 4;

                    Task22 task22 = new Task22(m22, p22);
                    task22.F2();
                    break;

                case 23:
                    double x23, b23;
                    x23 = 5.2; b23 = 0.3;

                    Task23 task23 = new Task23(x23, b23);
                    task23.F2();
                    break;

                case 24:
                    double t24, b24;
                    t24 = 6.2; b24 = 1.8;

                    Task24 task24 = new Task24(b24, t24);
                    task24.F2();
                    break;

                case 25:
                    double a25, p25;
                    a25 = 2; p25 = 2.6;

                    Task25 task25 = new Task25(a25, p25);
                    task25.F2();
                    break;

                case 26:
                    double b26, t26;
                    t26 = 2; b26 = 8.1;

                    Task26 task26 = new Task26(b26, t26);
                    task26.F2();
                    break;

                case 27:
                    double t27, a27;
                    t27 = 3; a27 = 76;

                    Task27 task27 = new Task27(t27, a27);
                    task27.F2();
                    break;

                case 28:
                    double b28, k28;
                    b28 = 2.19; k28 = 1.7;
                    Task28 task28 = new Task28(b28, k28);
                    task28.F2();
                    break;

                case 29:
                    double a29, b29;
                    a29 = 6; b29 = 4.3;

                    Task29 task29 = new Task29(a29, b29);
                    task29.F2();
                    break;

                case 30:
                    double t30, b30;
                    t30 = 3; b30 = 4.2;

                    Task30 task30 = new Task30(b30, t30);
                    task30.F2();
                    break;

            }

        }
    }
}
