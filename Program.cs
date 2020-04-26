using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[1];
            Chevrolet[] chevrolets = new Chevrolet[1];
            Ferrari[] ferraries = new Ferrari[1];
            Mercedes[] mercedeses = new Mercedes[1];
            int b = 20;
            int c = 20;
            int d = 20;
            int e = 20;
            while (true)
            {
                Console.WriteLine("Добро пожаловать в меню");
                Console.WriteLine("Для работы с обычным автомобилем нажмите 1");
                Console.WriteLine("Для работы с шевроле нажмите 2");
                Console.WriteLine("Для работы с феррари нажмите 3");
                Console.WriteLine("Для работы с мерседесами нажмите 4");
                Console.WriteLine("Для выхода из программы нажмите 0");
                int a = Convert.ToInt32(Checks.CheckSingleInput());
                switch (a)
                {
                    case 1:
                        while (true)
                        {
                            if (b == 0)
                            {
                                b = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для вычисления расстояния которое может пройти автомобиль введите 10");
                            Console.WriteLine("Для сравнения двух автомобилей по максимальной скорости введите 11");
                            Console.WriteLine("Для полного сравнения двух автомобилей введите 12");
                            Console.WriteLine("Для получения второй точной копии одного из автомобилей введите 13");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            b = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (b)
                            {
                                case 1:
                                    if (Car.TotalAmountOfCars == 0)
                                    {

                                        cars[0] = new Car();
                                        cars[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                        
    }
                                    else
                                    {
                                        Array.Resize(ref cars, cars.Length + 1);
                                        cars[cars.Length - 1] = new Car();
                                        cars[cars.Length-1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[cars.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[cars.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Car.TotalAmountOfCars == 0)
                                    {

                                        cars[0] = new Car(str);
                                        cars[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref cars, cars.Length + 1);
                                        cars[cars.Length - 1] = new Car(str);
                                        cars[cars.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[cars.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        cars[cars.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        cars[cars.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", cars.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Information(); break;
                                case 5 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта, который хотите изменить (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Modification(); break;
                                case 6 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого нужно переключить передачу  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].GearShift(); break;
                                case 7 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно починить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Repair(); break;
                                case 8 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно ускорить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Accelerate(); break;
                                case 9 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно улучшить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Upgrade(); break;
                                case 10 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,для которого нужно посчитать расстояние  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите время которое будет двигаться объект");
                                    double time = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                    Console.WriteLine("{0}", cars[i].Move(time)); break;
                                case 11 when Car.TotalAmountOfCars > 1:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", cars.Length - 1);
                                    int j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    int equal = cars[i].CompareTo(cars[j]);
                                    if (equal == 1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} больше скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == 0)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} равна скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == -1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} меньше скорости объекта с индексом {1}", i, j);
                                    }
                                    break;
                                case 12 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", cars.Length - 1);
                                    j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    bool equals = cars[i].Equals(cars[j]);
                                    if (equals == true)
                                    {
                                        Console.WriteLine("Объекты равны");
                                    }
                                    if (equals == false)
                                    {
                                        Console.WriteLine("Объекты не равны");
                                    }
                                    break;
                                case 13 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно клонировать  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Car cloneCar = (Car)cars[i].Clone();
                                    Console.WriteLine("Получен клон объекта");
                                    Console.WriteLine("Информация о нём:");
                                    cloneCar.Information();
                                    break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    b = 20; break;

                            }

                        }
                        break;
                    case 2:
                        while (true)
                        {
                            if (c == 0)
                            {
                                c = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в кабриолет введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную шевроле введите 11");
                            Console.WriteLine("Для вычисления расстояния которое может пройти шевроле введите 12");
                            Console.WriteLine("Для сравнения двух шевроле по максимальной скорости введите 13");
                            Console.WriteLine("Для полного сравнения двух шевроле введите 14");
                            Console.WriteLine("Для получения второй точной копии одного из шевроле введите 15");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            c = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (c)
                            {
                                case 1:
                                    if (Chevrolet.TotalAmountOfChevrolets == 0)
                                    {

                                        chevrolets[0] = new Chevrolet();
                                        chevrolets[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref chevrolets, chevrolets.Length + 1);
                                        chevrolets[chevrolets.Length - 1] = new Chevrolet();
                                        chevrolets[chevrolets.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[chevrolets.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[chevrolets.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };

                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Chevrolet.TotalAmountOfChevrolets == 0)
                                    {

                                        chevrolets[0] = new Chevrolet(str);
                                        chevrolets[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref chevrolets, chevrolets.Length + 1);
                                        chevrolets[chevrolets.Length - 1] = new Chevrolet(str);
                                        chevrolets[chevrolets.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[chevrolets.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        chevrolets[chevrolets.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        chevrolets[chevrolets.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", chevrolets.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Information(); break;
                                case 5 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Modification(); break;
                                case 6 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта, у которого нужно переключить передачу (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].GearShift(); break;
                                case 7 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно починить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Repair(); break;
                                case 8 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно ускорить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Accelerate(); break;
                                case 9 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно улучшить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Upgrade(); break;
                                case 10 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно сделать кабриалетом (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].ToCabriolet(); break;
                                case 11 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно сделать обычным (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].ToGeneralCar(); break;
                                case 12 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,для которого нужно посчитать расстояние  (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите время которое будет двигаться объект");
                                    double time = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                    Console.WriteLine("{0}", chevrolets[i].Move(time)); break;
                                case 13 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", chevrolets.Length - 1);
                                    int j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    int equal = chevrolets[i].CompareTo(chevrolets[j]);
                                    if (equal == 1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} больше скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == 0)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} равна скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == -1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} меньше скорости объекта с индексом {1}", i, j);
                                    }
                                    break;
                                case 14 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", chevrolets.Length - 1);
                                    j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    bool equals = chevrolets[i].Equals(chevrolets[j]);
                                    if (equals == true)
                                    {
                                        Console.WriteLine("Объекты равны");
                                    }
                                    if (equals == false)
                                    {
                                        Console.WriteLine("Объекты не равны");
                                    }
                                    break;
                                case 15 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно клонировать  (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Chevrolet cloneCar = (Chevrolet)chevrolets[i].Clone();
                                    Console.WriteLine("Получен клон объекта");
                                    Console.WriteLine("Информация о нём:");
                                    cloneCar.Information();
                                    break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    c = 20; break;
                            }

                        }
                        break;
                    case 3:
                        while (true)
                        {
                            if (d == 0)
                            {
                                d = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в гоночную модель введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную феррари введите 11");
                            Console.WriteLine("Для вычисления расстояния которое может пройти феррари введите 12");
                            Console.WriteLine("Для сравнения двух феррари по максимальной скорости введите 13");
                            Console.WriteLine("Для полного сравнения двух феррари введите 14");
                            Console.WriteLine("Для получения второй точной копии одного из феррари введите 15");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            d = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (d)
                            {
                                case 1:
                                    if (Ferrari.TotalAmountOfFerraries == 0)
                                    {

                                        ferraries[0] = new Ferrari();
                                        ferraries[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref ferraries, ferraries.Length + 1);
                                        ferraries[ferraries.Length - 1] = new Ferrari();
                                        ferraries[ferraries.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[ferraries.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[ferraries.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Ferrari.TotalAmountOfFerraries == 0)
                                    {

                                        ferraries[0] = new Ferrari(str);
                                        ferraries[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref ferraries, ferraries.Length + 1);
                                        ferraries[ferraries.Length - 1] = new Ferrari(str);
                                        ferraries[ferraries.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[ferraries.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        ferraries[ferraries.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        ferraries[ferraries.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", ferraries.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Information(); break;
                                case 5 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Modification(); break;
                                case 6 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого хотите переключить передачу(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].GearShift(); break;
                                case 7 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите починить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Repair(); break;
                                case 8 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите ускорить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Accelerate(); break;
                                case 9 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите улучшить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Upgrade(); break;
                                case 10 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать гоночным(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].ToRacing(); break;
                                case 11 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать обычным(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].ToGeneral(); break;
                                case 12 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,для которого нужно посчитать расстояние  (от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите время которое будет двигаться объект");
                                    double time = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                    Console.WriteLine("{0}", ferraries[i].Move(time)); break;
                                case 13 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", ferraries.Length - 1);
                                    int j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    int equal = ferraries[i].CompareTo(ferraries[j]);
                                    if (equal == 1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} больше скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == 0)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} равна скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == -1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} меньше скорости объекта с индексом {1}", i, j);
                                    }
                                    break;
                                case 14 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", ferraries.Length - 1);
                                    j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    bool equals = ferraries[i].Equals(ferraries[j]);
                                    if (equals == true)
                                    {
                                        Console.WriteLine("Объекты равны");
                                    }
                                    if (equals == false)
                                    {
                                        Console.WriteLine("Объекты не равны");
                                    }
                                    break;
                                case 15 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно клонировать  (от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Ferrari cloneCar = (Ferrari)ferraries[i].Clone();
                                    Console.WriteLine("Получен клон объекта");
                                    Console.WriteLine("Информация о нём:");
                                    cloneCar.Information();
                                    break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    d = 20; break;
                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            if (e == 0)
                            {
                                e = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в тонированную модель введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную мерседес введите 11");
                            Console.WriteLine("Для перехода мерседеса в новый класс введите 12");
                            Console.WriteLine("Для вычисления расстояния которое может пройти мерседесов введите 13");
                            Console.WriteLine("Для сравнения двух мерседесов по максимальной скорости введите 14");
                            Console.WriteLine("Для полного сравнения двух мерседесов введите 15");
                            Console.WriteLine("Для получения второй точной копии одного из мерседесов введите 16");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            e = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (e)
                            {
                                case 1:
                                    if (Mercedes.TotalAmountOfMercedes == 0)
                                    {

                                        mercedeses[0] = new Mercedes();
                                        mercedeses[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref mercedeses, mercedeses.Length + 1);
                                        mercedeses[mercedeses.Length - 1] = new Mercedes();
                                        mercedeses[mercedeses.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[mercedeses.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[mercedeses.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Mercedes.TotalAmountOfMercedes == 0)
                                    {

                                        mercedeses[0] = new Mercedes(str);
                                        mercedeses[0].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[0].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[0].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[0].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    else
                                    {
                                        Array.Resize(ref mercedeses, mercedeses.Length + 1);
                                        mercedeses[mercedeses.Length - 1] = new Mercedes(str);
                                        mercedeses[mercedeses.Length - 1].AboutToBlow += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].Exploded += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[mercedeses.Length - 1].CarIsDoomed += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].MoneyIsntEnough += (sender, e) => { Console.WriteLine(e.msg); };
                                        mercedeses[mercedeses.Length - 1].Crash += (sender, е) => { Console.WriteLine(е.msg); };
                                        mercedeses[mercedeses.Length - 1].CarIsCrashed += (sender, e) => { Console.WriteLine(e.msg); };
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", mercedeses.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Information(); break;
                                case 5 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Modification(); break;
                                case 6 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого хотите переключить передачу (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].GearShift(); break;
                                case 7 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите починить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Repair(); break;
                                case 8 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите ускорить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Modification(); break;
                                case 9 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите улучшить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Upgrade(); break;
                                case 10 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать тонированным (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ToTintCar(); break;
                                case 11 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать обычным (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ToGeneral(); break;
                                case 12 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,класс которого хотите изменить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ChangeClass(); break;
                                case 13 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,для которого нужно посчитать расстояние  (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите время которое будет двигаться объект");
                                    double time = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                    Console.WriteLine("{0}", mercedeses[i].Move(time)); break;
                                case 14 when Mercedes.TotalAmount != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", mercedeses.Length - 1);
                                    int j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    int equal = mercedeses[i].CompareTo(mercedeses[j]);
                                    if (equal == 1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} больше скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == 0)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} равна скорости объекта с индексом {1}", i, j);
                                    }
                                    if (equal == -1)
                                    {
                                        Console.WriteLine("Скорость объекта с индексом {0} меньше скорости объекта с индексом {1}", i, j);
                                    }
                                    break;
                                case 15 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс первого сравниваемого объекта(от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Console.WriteLine("Введите индекс второго сравниваемого объекта(от 0 и до {0})", mercedeses.Length - 1);
                                    j = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (j < 0 || j > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        j = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    bool equals = mercedeses[i].Equals(mercedeses[j]);
                                    if (equals == true)
                                    {
                                        Console.WriteLine("Объекты равны");
                                    }
                                    if (equals == false)
                                    {
                                        Console.WriteLine("Объекты не равны");
                                    }
                                    break;
                                case 16 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно клонировать  (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    Mercedes cloneCar = (Mercedes)mercedeses[i].Clone();
                                    Console.WriteLine("Получен клон объекта");
                                    Console.WriteLine("Информация о нём:");
                                    cloneCar.Information();
                                    break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    e = 20; break;
                            }
                        }
                        break;
                    case 0: return;
                    default: break;
                }
            }

        }
    }
}
