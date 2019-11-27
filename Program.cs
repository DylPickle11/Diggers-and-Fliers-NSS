using System;
using System.Collections.Generic;


namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.

            IDigContainer animalsDigging = new IDigContainer();
            IFlyContainer animalsThatFly = new IFlyContainer();
            ISwimContainer animalsThatSwim = new ISwimContainer();
            IMoveContainer animalsThatMove = new IMoveContainer();


            Earthworm Ernie = new Earthworm();
            Ernie.Name = "Ernie";
            Earthworm Ethel = new Earthworm();
            Ernie.Name = "Ethel";
            animalsDigging.animalsThatDig.Add(Ernie);
            animalsDigging.animalsThatDig.Add(Ethel);


            Ant Andy = new Ant();
            Andy.Name = "Andy";
            Ant Anita = new Ant();
            Anita.Name = "Anita";
            animalsDigging.animalsThatDig.Add(Andy);
            animalsDigging.animalsThatDig.Add(Anita);
            animalsThatMove.Movers.Add(Andy);
            animalsThatMove.Movers.Add(Anita);

            CopperHeadSnake Carl = new CopperHeadSnake();
            Carl.Name = "Carl";
            CopperHeadSnake Carly = new CopperHeadSnake();
            Carly.Name = "Carly";
            animalsThatMove.Movers.Add(Carl);
            animalsThatMove.Movers.Add(Carly);


            Finch Frankie = new Finch();
            Frankie.Name = "Frankie";
            Finch Fellina = new Finch();
            Fellina.Name = "Fellina";
            animalsThatFly.Fliers.Add(Frankie);
            animalsThatFly.Fliers.Add(Fellina);

            Fish Fanny = new Fish();
            Fanny.Name = "Fanny";
            Fish Felix = new Fish();
            Felix.Name = "Felix";
            animalsThatSwim.Swimmers.Add(Fanny);
            animalsThatSwim.Swimmers.Add(Felix);

            Gerbil Gretel = new Gerbil();
            Gretel.Name = "Gretel";
            Gerbil Gary = new Gerbil();
            Gary.Name = "Gary";
            animalsDigging.animalsThatDig.Add(Gretel);
            animalsDigging.animalsThatDig.Add(Gary);
            animalsThatMove.Movers.Add(Gretel);
            animalsThatMove.Movers.Add(Gary);

            Mouse Mandy = new Mouse();
            Mandy.Name = "Mandy";
            Mouse Matt = new Mouse();
            Matt.Name = "Matt";
            animalsDigging.animalsThatDig.Add(Mandy);
            animalsDigging.animalsThatDig.Add(Matt);
            animalsThatMove.Movers.Add(Mandy);
            animalsThatMove.Movers.Add(Matt);

            Parakeet Parry = new Parakeet();
            Ernie.Name = "Ernie";
            Parakeet Patricia = new Parakeet();
            Ernie.Name = "Ernie";
            animalsThatFly.Fliers.Add(Parry);
            animalsThatFly.Fliers.Add(Patricia);

            RattleSnake Randy = new RattleSnake();
            RattleSnake Rachel = new RattleSnake();
            Randy.Name = "Randy";
            animalsThatMove.Movers.Add(Randy);
            Rachel.Name = "Rachel";
            animalsThatMove.Movers.Add(Rachel);

            Terrapin Tim = new Terrapin();
            Terrapin Tina = new Terrapin();
            Tim.Name = "Tim";
            Tina.Name = "Tina";
            animalsThatMove.Movers.Add(Tina);
            animalsThatMove.Movers.Add(Tim);
            animalsThatSwim.Swimmers.Add(Tina);
            animalsThatSwim.Swimmers.Add(Tim);

            animalsDigging.animalsThatDig.ForEach(animal =>
           {
               Console.WriteLine($"Animals that Dig: {animal.Name} {animal.GetType().ToString().Split('.')[1]}");
           });

            animalsThatMove.Movers.ForEach(animal =>
            {
                Console.WriteLine($"Animals that Move: {animal.Name} {animal.GetType().ToString().Split('.')[1]}");
            });
            Console.WriteLine("////////////////////////////////////////");

            animalsThatSwim.Swimmers.ForEach(animal =>
          {
              Console.WriteLine($"Animals that Swim: {animal.Name} {animal.GetType().ToString().Split('.')[1]}");
          });
            Console.WriteLine("////////////////////////////////////////");

            animalsThatFly.Fliers.ForEach(animal =>
          {
              Console.WriteLine($"Animals that Fly: {animal.Name} {animal.GetType().ToString().Split('.')[1]}");
          });
            Console.WriteLine("////////////////////////////////////////");


        }
    }
}