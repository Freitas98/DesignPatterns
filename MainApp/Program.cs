using System;
using System.Security.Cryptography;
using Adapter;
using Command;
using Composite;
using Decorator;
using Factory;
using Iterator;
using Observer;
using Singleton;
using State;
using Strategy;
using TemplateMethod;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainTemplateMethod();
            //MainFactory();
            //MainFactoryMethod();
            //MainAbstractFactory();
            //MainSingleton();
            //MainDecorator();
            //MainAdapter();
            //MainObserver();
            //IteratorMain();
            //MainComposite();
            //MainState();
            //MainCommand();
            MainStrategy();
        }

        public static void MainTemplateMethod()
        {
            AbstractClass c1 = new ConcreteClass1();
            AbstractClass c2 = new ConcreteClass2();
            c1.TemplateMethod();
            c2.TemplateMethod();
        }

        public static void MainFactory()
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            var p1 = pizzaFactory.CreatePizza("Pepperoni");
            var p2 = pizzaFactory.CreatePizza("Cheese");
            var p3 = pizzaFactory.CreatePizza("Pepperoni");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
        }

        public static void MainFactoryMethod()
        {
            FactoryMethod f1 = new ConcreteFactoryMethodClass1();
            FactoryMethod f2 = new ConcreteFactoryMethodClass2();

            f1.ImprimirPizza();
            f2.ImprimirPizza();
        }

        public static void MainAbstractFactory()
        {
            AbstractFactory af = new ConcretePizzaFactory1();

            var p1 = af.CriarPizzaQueijo();
            var p2 = af.CriarPizzaPepperoni();

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }

        public static void MainSingleton()
        {
            MaquinaHelloWorld.Instance.HelloWorld();
        }

        public static void MainDecorator()
        {
            Pao p1 = new PaoQueijo(); // 1.8€
            p1 = new Alface(p1); // 0.4€
            p1 = new Tomate(p1); // 0.25€
            p1 = new Alface(p1); // 0.4€
            p1 = new Queijo(p1); // 0.15€

            Console.WriteLine("Produto comprado: " + p1.Descricao);
            Console.WriteLine("Preco: " + p1.Custo() + " Euros");

            Pao p2 = new PaoBatata(); // 1.2€
            p2 = new Alface(p2); // 0.4€
            p2 = new Queijo(p2); // 0.15€

            Console.WriteLine("Produto comprado: " + p2.Descricao);
            Console.WriteLine("Preco: " + p2.Custo() + " Euros");
        }

        public static void MainAdapter()
        {
            UsefulIncompatibleClass adaptee = new UsefulIncompatibleClass();
            IClientInterface target = new Adapter.Adapter(adaptee);

            Console.WriteLine("A classe UsefulIncompatibleClass é incompátível com a interface do cliente.\n");
            Console.WriteLine("Mas com a classe Adapter o cliente consegue utilizar os seus métodos.\n");
            
            target.MetodoUsadoCliente1();
            target.MetodoUsadoCliente2();
        }

        public static void MainObserver()
        {
            var doc = new Document("Trabalho Engenharia Software");
            IObserver observer1 = new ConcreteObserver();
            IObserver observer2 = new ConcreteObserver();

            doc.AddObserver(observer1);

            doc.AlterarNomeDocumento("Trabalho E.S");
            doc.AlterarNomeDocumento("Trabalho Eng. Software");

            doc.AddObserver(observer2);

            doc.AlterarNomeDocumento("Trabalho E. Soft");

            doc.RemoveObserver(observer1);
            doc.RemoveObserver(observer2);

            doc.AlterarNomeDocumento("Trabalho Eng. Soft");
        }

        public static void IteratorMain()
        {
            Animal[] animais = new Animal[5];

            animais[0] = new Animal("Leão");
            animais[1] = new Animal("Zebra");
            animais[2] = new Animal("Porco");
            animais[3] = new Animal("Vaca");
            animais[4] = new Animal("Galo");

            AnimalMenu menuAnimais = new AnimalMenu(animais);

            Console.WriteLine("Vou iterar sobre o conjunto de animais...\n");

            var iteratorAnimais = menuAnimais.GetIterator();

            while (iteratorAnimais.HasNext())
            {
                Console.WriteLine((iteratorAnimais.Next() as Animal).Name);
            }

            while (iteratorAnimais.HasNext())
            {
                Console.WriteLine((iteratorAnimais.Next() as Animal).Name);
            }

            Console.WriteLine("\nComo o iterator chegou ao fim mesmo que eu percorra não exibe elementos pois não tem mais elementos para percorrer...\n");

            Console.WriteLine("Resetando a posição do iterator...\n");
            iteratorAnimais.Reset();

            Console.WriteLine("Vou iterar novamente sobre sobre o conjunto de animais...\n");

            while (iteratorAnimais.HasNext())
            {
                Console.WriteLine((iteratorAnimais.Next() as Animal).Name);
            }
        }

        public static void MainComposite()
        {
            ItemSistemaOperativo p1 = new Pasta("Pasta do João");

            p1.Print();

            ItemSistemaOperativo f1 = new Ficheiro("Relatório E.S");

            f1.Print();

            p1.Add(f1);
            f1.AlterarFicheiro();

            p1.Print();

            ItemSistemaOperativo f2 = new Ficheiro("Relatório Eng. Requisitos");

            f2.Print();

            p1.Add(f2);
            f2.AlterarFicheiro();

            p1.Print();

            ItemSistemaOperativo p2 = new Pasta("Universidade");

            p2.Print();

            p2.Add(p1);

            p2.Print();

            ItemSistemaOperativo f3 = new Ficheiro("Relatório I.A");

            f3.Print();

            p2.Add(f3);

            p2.Print();

        }

        public static void MainState()
        {
            Documento doc = new Documento(); // Começa no estado em avaliação

            doc.VerificarEstado();

            doc.AceitarDocumento(); // Passa a estado aprovado

            doc.VerificarEstado();

            doc.RejeitarDocumento(); // Continua em aprovado, transição não é possível

            doc.VerificarEstado();

            doc.AvaliarDocumento(); // Passa a estado em avaliação

            doc.VerificarEstado();

            doc.RejeitarDocumento(); // Passa a estado rejeitado

            doc.VerificarEstado();
        }

        public static void MainCommand()
        {
            Luz l1 = new Luz();
            ICommand c1 = new ComandoLigarLuz(l1);

            Console.WriteLine("Estado da luz: " + l1.Acesa);

            c1.Execute();
            
            Console.WriteLine("Estado da luz: " + l1.Acesa);

            c1.Undo();

            Console.WriteLine("Estado da luz: " + l1.Acesa);

            c1.Redo();

            Console.WriteLine("Estado da luz: " + l1.Acesa);
        }

        public static void MainStrategy()
        {
            IAlgoritmoEstrategia e1 = new Estrategia1();
            IAlgoritmoEstrategia e2 = new Estrategia2();

            Cliente c1 = new Cliente(e1);

            c1.FuncaoDoCliente();

            c1.EstrategiaUsar = e2;

            c1.FuncaoDoCliente();
        }
    }
}
