using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Opc
    {
        Arbol arbol = new Arbol();
        Tree tree = new Tree();
        Tree tree2 = new Tree();

        public void Opcion (int opc)
        {
            if (opc == 1)
            {

            }

            if (opc == 2)
            {

            }

            if (opc == 3)
            {

            }

            if (opc == 4)
            {
                Nodo x, y;
                Nodo raiz = arbol.Insertar("B", null); //Nodo raiz

                Nodo a = arbol.Insertar("A", raiz);
                Nodo n = arbol.Insertar("N", a);
                a = arbol.Insertar("A", n);
                n = arbol.Insertar("N", a);
                a = arbol.Insertar("A", n);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("M", null);
                y = arbol.Insertar("E", raiz);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("C", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("T", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("N", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("M", null);
                x = arbol.Insertar("A", raiz);
                y = arbol.Insertar("N", x);
                x = arbol.Insertar("Z", y);
                y = arbol.Insertar("A", x);
                x = arbol.Insertar("N", y);
                y = arbol.Insertar("A", x);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("P", null);
                x = arbol.Insertar("E", raiz);
                y = arbol.Insertar("R", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("C", null);
                x = arbol.Insertar("O", raiz);
                y = arbol.Insertar("C", x);
                x = arbol.Insertar("O", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("M", null);
                x = arbol.Insertar("A", raiz);
                y = arbol.Insertar("N", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("O", x);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("P", null);
                x = arbol.Insertar("A", raiz);
                y = arbol.Insertar("P", x);
                x = arbol.Insertar("A", y);
                y = arbol.Insertar("Y", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);
            }

            if (opc == 5)
            {
                Nodo raiz, x, y;

                raiz = arbol.Insertar("E", null);
                x = arbol.Insertar("N", raiz);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("F", null);
                x = arbol.Insertar("R", raiz);
                y = arbol.Insertar("E", x);
                x = arbol.Insertar("N", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("C", null);
                x = arbol.Insertar("A", raiz);
                y = arbol.Insertar("M", x);
                x = arbol.Insertar("P", y);
                y = arbol.Insertar("A", x);
                x = arbol.Insertar("N", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("O", null);
                x = arbol.Insertar("R", raiz);
                y = arbol.Insertar("N", x);
                x = arbol.Insertar("I", y);
                y = arbol.Insertar("T", x);
                x = arbol.Insertar("O", y);
                y = arbol.Insertar("L", x);
                x = arbol.Insertar("O", y);
                y = arbol.Insertar("G", x);
                x = arbol.Insertar("I", y);
                y = arbol.Insertar("A", x);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("I", null);
                x = arbol.Insertar("C", raiz);
                y = arbol.Insertar("T", x);
                x = arbol.Insertar("I", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("L", null);
                x = arbol.Insertar("I", raiz);
                y = arbol.Insertar("M", x);
                x = arbol.Insertar("N", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("A", null);
                x = arbol.Insertar("L", raiz);
                y = arbol.Insertar("Q", x);
                x = arbol.Insertar("U", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("M", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);

                Console.WriteLine();
                raiz = arbol.Insertar("A", null);
                x = arbol.Insertar("S", raiz);
                y = arbol.Insertar("T", x);
                x = arbol.Insertar("R", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("L", y);
                y = arbol.Insertar("O", x);
                x = arbol.Insertar("G", y);
                y = arbol.Insertar("I", x);
                x = arbol.Insertar("A", y);
                arbol.Imprimir(raiz);
            }

            if (opc == 6)
            {
                Nodo raiz, x, y;
                raiz = arbol.Insertar("E", null);
                x = arbol.Insertar("l", raiz);
                y = arbol.Insertar(" ", x);
                x = arbol.Insertar("r", y);
                y = arbol.Insertar("a", x);
                x = arbol.Insertar("p", y);
                y = arbol.Insertar("i", x);
                x = arbol.Insertar("d", y);
                y = arbol.Insertar("o", x);
                x = arbol.Insertar(" ", y);
                y = arbol.Insertar("z", x);
                x = arbol.Insertar("o", y);
                y = arbol.Insertar("r", x);
                x = arbol.Insertar("r", y);
                y = arbol.Insertar("o", x);
                x = arbol.Insertar(" ", y);
                y = arbol.Insertar("m", x);
                x = arbol.Insertar("a", y);
                y = arbol.Insertar("r", x);
                x = arbol.Insertar("r", y);
                y = arbol.Insertar("o", x);
                x = arbol.Insertar("n", y);
                y = arbol.Insertar(" ", x);
                x = arbol.Insertar("s", y);
                y = arbol.Insertar("a", x);
                x = arbol.Insertar("l", y);
                y = arbol.Insertar("t", x);
                x = arbol.Insertar("a", y);
                y = arbol.Insertar(" ", x);
                x = arbol.Insertar("s", y);
                y = arbol.Insertar("o", x);
                x = arbol.Insertar("b", y);
                y = arbol.Insertar("r", x);
                x = arbol.Insertar("e", y);
                y = arbol.Insertar(" ", x);
                x = arbol.Insertar("e", y);
                y = arbol.Insertar("l", x);
                x = arbol.Insertar(" ", y);
                y = arbol.Insertar("p", x);
                x = arbol.Insertar("e", y);
                y = arbol.Insertar("r", x);
                x = arbol.Insertar("r", y);
                y = arbol.Insertar("o", x);
                x = arbol.Insertar(" ", y);
                y = arbol.Insertar("p", x);
                x = arbol.Insertar("e", y);
                y = arbol.Insertar("r", x);
                x = arbol.Insertar("e", y);
                y = arbol.Insertar("z", x);
                x = arbol.Insertar("o", y);
                y = arbol.Insertar("s", x);
                x = arbol.Insertar("o", y);
                arbol.Imprimir(raiz);
            }

            if (opc == 7)
            {         
            }

            if (opc == 8)
            {
                tree.Insert(-1);
                tree.Insert(0);
                tree.Insert(2);
                tree.Insert(-2);
                tree.Insert(3);
                tree.Insert(6);
                tree.Insert(-3);
                tree.Insert(5);
                tree.Insert(1);
                tree.Insert(4);
                tree.Inorder(tree.ReturnRoot());

                Console.WriteLine();
                tree2.Insert(-1);
                tree2.Insert(7);
                tree2.Insert(4);
                tree2.Insert(11);
                tree2.Insert(5);
                tree2.Insert(-8);
                tree2.Insert(15);
                tree2.Insert(-3);
                tree2.Insert(-2);
                tree2.Insert(6);
                tree2.Insert(10);
                tree2.Insert(3);
                tree2.Inorder(tree2.ReturnRoot());
            }

            if (opc == 9)
            {

            }


            if (opc == 10)
            {

            }
        }
    }
}
