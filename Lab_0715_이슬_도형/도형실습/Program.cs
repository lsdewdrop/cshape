using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도형실습
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TwoDim> two =new List<TwoDim>();
            List<ThreeDim> three = new List<ThreeDim>();
            while(true)
            {
                Console.WriteLine("단위크기를 입력해주세요.");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("모양을 입력해주세요.(정사각형, 정삼각형, 원, 구, 정사면체)");
                string mo = Console.ReadLine();
                if(mo=="정사각형")
                {
                    int check=0;
                    for(int i=0; i<two.Count; i++)
                    {
                        if(two[i].mmo==0 && two[i].rr==num)
                        {
                            check=1;
                        }
                    }
                    if(check==0)
                    {
                        TwoDim sakak = new jsakak(num);
                        sakak.cal();
                        sakak.print();
                        two.Add(sakak);

                    }
                    else
                    {
                        Console.WriteLine("이미 같은 모양과 크기의 도형이 있습니다.");
                    }
                }
                else if(mo=="정삼각형")
                {
                    int check=0;
                    for(int i=0; i<two.Count; i++)
                    {
                        if (two[i].mmo == 1 && two[i].rr == num)
                        {
                            check=1;
                        }
                    }
                    if(check==0)
                    {
                        TwoDim samkak = new jsamkak(num);
                        samkak.cal();
                        samkak.print();
                        two.Add(samkak);
                    }
                    else
                    {
                        Console.WriteLine("이미 같은 모양과 크기의 도형이 있습니다.");
                    }
                }

                else if (mo == "원")
                {
                    int check = 0;
                    for (int i = 0; i < two.Count; i++)
                    {
                        if (two[i].mmo == 2 && two[i].rr == num)
                        {
                            check = 1;
                        }
                    }
                    if (check == 0)
                    {
                        TwoDim onee = new one(num);
                        onee.cal();
                        onee.print();
                        two.Add(onee);
                    }
                    else
                    {
                        Console.WriteLine("이미 같은 모양과 크기의 도형이 있습니다.");
                    }
                }
                else if (mo == "구")
                {
                    int check = 0;
                    for (int i = 0; i < three.Count; i++)
                    {
                        if (three[i].mmo == 0 && three[i].rr == num)
                        {
                            check = 1;
                        }
                    }
                    if (check == 0)
                    {
                        ThreeDim guu = new gu(num);
                        guu.cal();
                        guu.print();
                        three.Add(guu);
                    }
                    else
                    {
                        Console.WriteLine("이미 같은 모양과 크기의 도형이 있습니다.");
                    }
                }

                else if (mo == "정사면체")
                {
                    int check = 0;
                    for (int i = 0; i < three.Count; i++)
                    {
                        if (three[i].mmo == 1 && three[i].rr == num)
                        {
                            check = 1;
                        }
                    }
                    if (check == 0)
                    {
                        ThreeDim jsa = new jsamun(num);
                        jsa.cal();
                        jsa.print();
                        three.Add(jsa);
                    }
                    else
                    {
                        Console.WriteLine("이미 같은 모양과 크기의 도형이 있습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("저 중에 하나를 입력해주세요.");
                }
            }
            
        }
    }

    abstract class shape
    {
        protected double nulby;
        public double rr {get;set;}
        public int mmo { get; set; }

        public abstract void cal();
    }


    abstract class TwoDim : shape
    {

        protected double dul;


        public void print()
        {
            Console.WriteLine("넓이 : " + nulby + " 둘레 : " + dul);
            
        }
    }

    abstract class ThreeDim : shape
    {

        protected double bupy;


        public void print()
        {
            Console.WriteLine("겉넓이 : " + nulby + " 부피 : " + bupy);
        }
    }


    class jsakak : TwoDim
    {
        public jsakak(int r)
        {
            mmo = 0;
            rr = r;
        }

        public override void cal()
        {
            nulby = rr * rr;
            dul = 4 * rr;
        }
    }

    class jsamkak : TwoDim
    {

        public jsamkak(int r)
        {
            mmo = 1;
            rr = r;
        }

        public override void cal()
        {
            nulby = Math.Pow(3, 0.5) * rr * rr / 4;
            dul = 3 * rr;
        }
    }

    class one : TwoDim
    {
        public one(int r)
        {
            mmo = 2;
            rr = r;
        }
        public override void cal()
        {
            nulby = 3.14 * rr * rr;
            dul = 2 * 3.14 * rr;
        }
    }

    class gu : ThreeDim
    {
        public gu(int r)
        {
            mmo = 0;
            rr = r;
        }
        public override void cal()
        {
            nulby = 4 * 3.14 * rr;
            bupy = (4 * 3.14 * rr * rr * rr )/ 3;
        }
    }

    class jsamun : ThreeDim
    {
        public jsamun(int r)
        {
            mmo = 1;
            rr = r;
        }
        public override void cal()
        {
            nulby = 6 * rr * rr;
            bupy = rr * rr * rr;
        }
    }
}
