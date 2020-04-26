using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{//поправить вывод и конструкторы!
    class Ferrari:Car, IComparable<Ferrari>,IEquatable<Ferrari>
    {
        public Ferrari() : base()
        {
            Console.WriteLine("Экзмепляр автомобиля оказался феррари");
            Console.WriteLine("Марка, страна и цвет теперь не могут быть изменены");
            totalAmountOfFerraries++;
            Console.WriteLine("Общее количество моделей феррари теперь равно:{0} ", totalAmountOfFerraries);
            Console.WriteLine("");
            mark = "Ferrari";
            country = "Italy";
            color = "Red";

        }
        public Ferrari(string name) : base(name)
        {
            Console.WriteLine("Экзмепляр автомобиля оказался феррари");
            Console.WriteLine("Марка, страна и цвет теперь не могут быть изменены");
            totalAmountOfFerraries++;
            Console.WriteLine("Общее количество моделей феррари теперь равно:{0} ", totalAmountOfFerraries);
            Console.WriteLine("");
            mark = "Ferrari";
            country = "Italy";
            color = "Red";
        }
        private static int totalAmountOfFerraries = 0;
        public static int TotalAmountOfFerraries => totalAmountOfFerraries;
        private bool isRacing = false;
        public override void Modification()
        {
            Console.WriteLine("Для изменения имени нажмите 2");
            Console.WriteLine("Для изменения веса нажмите 3");
            Console.WriteLine("Для изменения количества мест нажмите 4");
            Console.WriteLine("Для изменения габаритов нажмите 5 и следуйте инструкции");
            Console.WriteLine("Для изменения состава нажмите 6 и следуйте инструкции");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            try
            {
                switch (n)
                {

                    case 2:
                        Console.WriteLine("Введите имя");
                        Name = Checks.CheckSingleStringInput(); break;
                    case 3:
                        Console.WriteLine("Введите вес");
                        Weight = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 4:
                        Console.WriteLine("Введите количество мест");
                        NumberOfSeats = Convert.ToInt32(Checks.CheckSingleInput()); break;


                    case 5:
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
                    case 6:
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
            if (isRacing == true)
            {
                Console.WriteLine("Феррари в гоночном режиме");
            }
            else
            {
                Console.WriteLine("Феррари в обычном режиме");
            }
            Console.WriteLine("");
        }
        public void ToRacing()
        {
            isRacing = true;
        }
        public void ToGeneral()
        {
            isRacing = false;
        }
        public override string Mark { get => mark; }
        public override string Country { get => country; }
        public override string Color { get => color; }
        public override double Move(double time)
        {
            double destination = CurrentSpeed * time + (ferrariBoost * time * time) / 2;
            return destination;
        }
        private static double ferrariBoost = 1.6;
        public override object Clone()
        {
            Ferrari auto = new Ferrari(this.Name);
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
            auto.isRacing = this.isRacing;
            return auto;
        }
        public bool Equals(Ferrari auto)
        {
            return (auto.currentSpeed == this.CurrentSpeed && auto.mark == this.Mark && auto.carIsDead == this.carIsDead && auto.color == this.Color &&
            auto.country == this.Country && auto.enginePower == this.enginePower && auto.gear == this.gear && auto.maxSpeed == this.MaxSpeed &&
            auto.money == this.Money && auto.motorIsDead == this.motorIsDead && auto.NumberOfSeats == this.NumberOfSeats &&
            auto.transportDimensions.height == this.transportDimensions.height && auto.transportDimensions.width == this.transportDimensions.width &&
            auto.transportDimensions.length == this.transportDimensions.length && auto.upgradeCounter == this.upgradeCounter &&
            auto.wheelIsLowered == this.wheelIsLowered &&  auto.numberOfSeats == this.NumberOfSeats &&
            auto.weight == this.Weight&&auto.isRacing==this.isRacing);

        }

        public int CompareTo(Ferrari auto)
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
