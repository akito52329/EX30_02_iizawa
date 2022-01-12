using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(new DateTime(2003, 1, 12), "A", 92, null,53.5f, 10000);//生徒
            student.SelfIntroduction();

            Worker worker = new Worker(new DateTime(1998, 12, 25), "B", 92, null,60.1f, 50000);//労働者
            worker.SelfIntroduction();

            Car car = new Car("ホンダ", 10);//車
            car.SelfIntroduction();

            Fish fish = new Fish(DateTime.Now, "マグロ", 10, true);//魚
            fish.SelfIntroduction();

            Insect insect = new Insect(new DateTime(2022, 7, 25), "セミ",7,"夏");//虫
            insect.SelfIntroduction();

            Refrigerator refrigerator = new Refrigerator("パナソニック", 10, "黒",60, 60, 180, 30, 30000);//冷蔵庫
            refrigerator.SelfIntroduction();

            Bird bird = new Bird(DateTime.Now, "カラス", 3650, "黒", 10);//鳥
            bird.SelfIntroduction();

            Cat cat = new Cat(DateTime.Now, "ペルシャ", 4380, "白", 10 , false);//猫
            cat.SelfIntroduction();
        }
    }
}
