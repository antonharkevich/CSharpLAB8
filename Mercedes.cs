using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Mercedes: Car, IEquatable<Mercedes>,IComparable<Mercedes>
    {
        public Mercedes() : base()
        {


            Console.WriteLine("Экзмепляр автомобиля оказался мерседесом");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfMercedes++;
            Console.WriteLine("Общее количество моделей мерседес теперь равно:{0} ", totalAmountOfMercedes);
            Console.WriteLine("");
            mark = "Mercedes";
            country = "Germany";

        }
        public Mercedes(string name) : base(name)
        {


            Console.WriteLine("Экзмепляр автомобиля оказался мерседесом");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfMercedes++;
            Console.WriteLine("Общее количество моделей мерседес теперь равно:{0} ", totalAmountOfMercedes);
            Console.WriteLine("");
            mark = "Mercedes";
            country = "Germany";
        }
        private static int totalAmountOfMercedes = 0;
        public static int TotalAmountOfMercedes => totalAmountOfMercedes;
        private bool isCarTint = false;
        char @class = 'A';
        public override void Modification()
        {


            Console.WriteLine("Для изменения имени нажмите 2");
            Console.WriteLine("Для изменения цвета нажмите 3");
            Console.WriteLine("Для изменения веса нажмите 4");
            Console.WriteLine("Для изменения количества мест нажмите 5");
            Console.WriteLine("Для изменения габаритов нажмите 6 и следуйте инструкции");
            Console.WriteLine("Для изменения состава нажмите 7 и следуйте инструкции");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            try
            {
                switch (n)
                {

                    case 2:
                        Console.WriteLine("Введите имя");
                        Name = Checks.CheckSingleStringInput(); break;
                    case 3:
                        Console.WriteLine("Введите цвет");
                        Color = Checks.CheckSingleStringInput(); break;
                    case 4:
                        Console.WriteLine("Введите вес");
                        Weight = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 5:
                        Console.WriteLine("Введите количество мест");
                        NumberOfSeats = Convert.ToInt32(Checks.CheckSingleInput()); break;


                    case 6:
                        ModificationOutput2();
                        int m = Convert.ToInt32(Checks.CheckSingleInput());
                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("Введите ширину");
                                double y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.width = y;
                                }
                                else
                                {
                                    InvalidArgumentException ex = new InvalidArgumentException();
                                    throw ex;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Введите высоту");
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.height = y;
                                }
                                else
                                {
                                    InvalidArgumentException ex = new InvalidArgumentException();
                                    throw ex;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Введите длину");
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.length = y;
                                }
                                else
                                {
                                    InvalidArgumentException ex = new InvalidArgumentException();
                                    throw ex;
                                }
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                        m = Convert.ToInt32(Checks.CheckSingleInput());
                        Console.WriteLine("Введите часть состава");
                        this[m - 1] = Checks.CheckSingleStringInput();
                        break;


                    default:
                        InvalidArgumentException exc = new InvalidArgumentException();
                        throw exc;

                }
            }
            catch (WrongInputException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            Console.WriteLine("");
        }
        public override void Information()
        {
            base.Information();
            if (isCarTint == true)
            {
                Console.WriteLine("Мерседес в режиме тонировки");
            }
            else
            {
                Console.WriteLine("Мерседес в обычном режиме");
            }
            Console.WriteLine("Текущий класс мерседеса:{0}", @class);
            Console.WriteLine("");
        }
        public void ToTintCar()
        {
            isCarTint = true;
        }
        public void ToGeneral()
        {
            isCarTint = false;
        }
        public override string Mark { get => mark; }
        public override string Country { get => country; }

        public void ChangeClass()
        {
            Console.WriteLine("Введите цифру класса");
            Console.WriteLine("1-A,2-B,3-C,4-D,5-E,6-G,7-M,8-S");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            try
            {
                switch (n)
                {
                    case 1: @class = 'A'; break;
                    case 2: @class = 'B'; break;
                    case 3: @class = 'C'; break;
                    case 4: @class = 'D'; break;
                    case 5: @class = 'E'; break;
                    case 6: @class = 'G'; break;
                    case 7: @class = 'M'; break;
                    case 8: @class = 'S'; break;
                    default:
                        InvalidArgumentException exc = new InvalidArgumentException();
                        throw exc;

                }
            }
            catch (WrongInputException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            Console.WriteLine("");
        
            
        }
        public override double Move(double time)
        {
            double destination = CurrentSpeed * time + (mercedesBoost * time * time) / 2;
            return destination;
        }
        private static double mercedesBoost = 1.4;
        public override object Clone()
        {
            Mercedes auto = new Mercedes(this.Name);
            auto.currentSpeed = this.CurrentSpeed;
            auto.mark = this.Mark;
            auto.carIsDead = this.carIsDead;
            auto.color = this.Color;
            auto.country = this.Country;
            auto.enginePower = this.enginePower;
            auto.gear = this.gear;
            auto.maxSpeed = this.MaxSpeed;
            auto.money = this.Money;
            auto.motorIsDead = this.motorIsDead;
            auto.NumberOfSeats = this.NumberOfSeats;
            auto.transportDimensions = this.transportDimensions;
            auto.upgradeCounter = this.upgradeCounter;
            auto.wheelIsLowered = this.wheelIsLowered;
            auto.composition = this.composition;
            auto.numberOfSeats = this.NumberOfSeats;
            auto.weight = this.Weight;
            auto.isCarTint = this.isCarTint;
            auto.@class = this.@class;
            return auto;
        }

        public bool Equals(Mercedes auto)
        {
            return (auto.currentSpeed == this.CurrentSpeed && auto.mark == this.Mark && auto.carIsDead == this.carIsDead && auto.color == this.Color &&
            auto.country == this.Country && auto.enginePower == this.enginePower && auto.gear == this.gear && auto.maxSpeed == this.MaxSpeed &&
            auto.money == this.Money && auto.motorIsDead == this.motorIsDead && auto.NumberOfSeats == this.NumberOfSeats &&
            auto.transportDimensions.height == this.transportDimensions.height && auto.transportDimensions.width == this.transportDimensions.width &&
            auto.transportDimensions.length == this.transportDimensions.length && auto.upgradeCounter == this.upgradeCounter &&
            auto.wheelIsLowered == this.wheelIsLowered  && auto.numberOfSeats == this.NumberOfSeats &&
            auto.weight == this.Weight&&auto.isCarTint==this.isCarTint&&auto.@class==this.@class);

        }

        public int CompareTo(Mercedes auto)
        {
            if (this.MaxSpeed < auto.MaxSpeed)
            {
                return -1;
            }
            else if (this.MaxSpeed > auto.MaxSpeed)
            {
                return 1;
            }
            else return 0;
        }
    }
}
