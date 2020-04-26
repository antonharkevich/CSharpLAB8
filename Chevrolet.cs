using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{//переопределить страну-производителя
    class Chevrolet : Car, IComparable<Chevrolet>, IEquatable<Chevrolet>
    {
        public Chevrolet() : base()
        {
            Console.WriteLine("Экзмепляр автомобиля оказался шевроле");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfChevrolets++;
            Console.WriteLine("Общее количество моделей шевроле теперь равно:{0} ", totalAmountOfChevrolets);
            Console.WriteLine("");
            mark = "Chevrolet";
            country = "The U.S.A";

        }
        public Chevrolet(string name) : base(name)
        {
            Console.WriteLine("Экзмепляр автомобиля оказался шевроле");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfChevrolets++;
            Console.WriteLine("Общее количество моделей шевроле теперь равно:{0} ", totalAmountOfChevrolets);
            Console.WriteLine("");
            mark = "Chevrolet";
            country = "The U.S.A";
        }
        private static int totalAmountOfChevrolets = 0;
        public static int TotalAmountOfChevrolets => totalAmountOfChevrolets;
        private bool isRoofRaised = false;
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
            if (isRoofRaised == true)
            {
                Console.WriteLine("Шевроле в режиме кабриолета");
            }
            else
            {
                Console.WriteLine("Шевроле в обычном режиме");
            }
            Console.WriteLine("");
        }
        public void ToCabriolet()
        {
            isRoofRaised = true;
        }
        public void ToGeneralCar()
        {
            isRoofRaised = false;
        }
        public override string Mark { get => mark; }
        public override string Country { get => country; }
        public override double Move(double time)
        {
            double destination = CurrentSpeed * time + (shevroletBoost * time * time) / 2;
            return destination;
        }
        private static double shevroletBoost = 1.2;
        public override object Clone()
        {
            Chevrolet auto = new Chevrolet(this.Name);
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
            auto.isRoofRaised = this.isRoofRaised;
            return auto;
        }
        public bool Equals(Chevrolet auto)
        {
            return (auto.currentSpeed == this.CurrentSpeed && auto.mark == this.Mark && auto.carIsDead == this.carIsDead && auto.color == this.Color &&
            auto.country == this.Country && auto.enginePower == this.enginePower && auto.gear == this.gear && auto.maxSpeed == this.MaxSpeed &&
            auto.money == this.Money && auto.motorIsDead == this.motorIsDead && auto.NumberOfSeats == this.NumberOfSeats &&
            auto.transportDimensions.height == this.transportDimensions.height && auto.transportDimensions.width == this.transportDimensions.width &&
            auto.transportDimensions.length == this.transportDimensions.length && auto.upgradeCounter == this.upgradeCounter &&
            auto.wheelIsLowered == this.wheelIsLowered && auto.numberOfSeats == this.NumberOfSeats &&
            auto.weight == this.Weight && auto.isRoofRaised == this.isRoofRaised);

        }

        public int CompareTo(Chevrolet auto)
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
