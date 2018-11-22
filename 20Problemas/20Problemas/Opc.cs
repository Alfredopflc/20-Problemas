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
                Nodo raiz = arbol.Insertar("a(4)", null);
                Nodo b = arbol.Insertar("b(2)", raiz);
                Nodo c = arbol.Insertar("c(8)", raiz);
                Nodo d = arbol.Insertar("d(1)", b);
                Nodo e = arbol.Insertar("e(3)", b);
                Nodo f = arbol.Insertar("f(6)", c);
                Nodo g = arbol.Insertar("g(10)", c);
                Nodo h = arbol.Insertar("h(5)", f);
                Nodo i = arbol.Insertar("i(7)", f);
                Nodo j = arbol.Insertar("j(9)", g);
                Nodo k = arbol.Insertar("k(11)", g);

                arbol.ImprimirArbol(raiz);
                Console.WriteLine();
                raiz = arbol.Insertar("a", null);
                b = arbol.Insertar("b", raiz);
                c = arbol.Insertar("c", raiz);
                d = arbol.Insertar("d", b);
                e = arbol.Insertar("e", b);
                f = arbol.Insertar("f", c);
                g = arbol.Insertar("g", c);
                arbol.ImprimirArbol(raiz);

                tree.Insert(4);
                tree.Insert(2);
                tree.Insert(8);
                tree.Insert(1);
                tree.Insert(3);
                tree.Insert(6);
                tree.Insert(10);
                tree.Insert(5);
                tree.Insert(7);
                tree.Insert(9);
                tree.Insert(11);
                Console.WriteLine("\nd,e,b,h,i,f,j,k,g,c,a");
                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot());
            }

            if (opc == 4)
            {              
                Nodo raiz = arbol.Insertar("Banana(1)", null); //Nodo raiz
                Nodo nada = arbol.Insertar("", raiz);
                Nodo Melocoton = arbol.Insertar("Melocoton(5)", raiz);
                Nodo Manzana = arbol.Insertar("Manzana(4)", Melocoton);

                Nodo Coco = arbol.Insertar("Coco(2)", Manzana);
                Nodo nada4 = arbol.Insertar("", Manzana);
                Nodo nada2 = arbol.Insertar("", Coco);
                Nodo Mango = arbol.Insertar("Mango(3)", Coco);
                Nodo Pera = arbol.Insertar("Pera(7)", Melocoton);
                Nodo Papaya = arbol.Insertar("Papaya(6)", Pera);

                arbol.ImprimirArbol(raiz);              
                tree.Insert(1);
                tree.Insert(5);
                tree.Insert(4);
                tree.Insert(7);
                tree.Insert(2);
                tree.Insert(3);
                tree.Insert(6);
                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot());
            }

            if (opc == 5)
            {
                Nodo raiz = arbol.Insertar("Econologia(4)", null);
                Nodo cam = arbol.Insertar("Campanologia(3)", raiz);
                Nodo fre = arbol.Insertar("Frenologia(5)", raiz);
                Nodo al = arbol.Insertar("Alquimia(1)", cam);
                Nodo nada1 = arbol.Insertar("", al);
                Nodo ast = arbol.Insertar("Astrologia(2)", al);
                Nodo nada2 = arbol.Insertar("", fre);
                Nodo orn = arbol.Insertar("Ornitologia(8)", fre);
                Nodo ic = arbol.Insertar("Ictionologia(6)", orn);
                Nodo nada3 = arbol.Insertar("", ic);
                Nodo lim = arbol.Insertar("Limnologia(7)", ic);

                arbol.ImprimirArbol(raiz);
                tree.Insert(4);
                tree.Insert(5);
                tree.Insert(3);
                tree.Insert(8);
                tree.Insert(6);
                tree.Insert(7);
                tree.Insert(1);
                tree.Insert(2);

                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot());
            }

            if (opc == 6)
            {
                Nodo raiz = arbol.Insertar("El(1)", null);
                Nodo nada = arbol.Insertar("", raiz);
                Nodo ra = arbol.Insertar("rapido(2)", raiz);
                Nodo ma = arbol.Insertar("marron(4)", ra);
                Nodo zo = arbol.Insertar("zorro(3)", ra);
                Nodo el = arbol.Insertar("el(7)", ma);
                Nodo pe = arbol.Insertar("perro(8)", ma);
                Nodo per = arbol.Insertar("perezoso(9)", pe);
                Nodo sa = arbol.Insertar("salta(5)", zo);
                nada = arbol.Insertar("", sa);
                Nodo so = arbol.Insertar("sobre(6)", sa);
                arbol.ImprimirArbol(raiz);

                tree.Insert(1);
                tree.Insert(6);
                tree.Insert(9);
                tree.Insert(3);
                tree.Insert(7);
                tree.Insert(8);
                tree.Insert(2);
                tree.Insert(5);
                tree.Insert(4);

                Console.WriteLine("El rápido zorro marrón salta sobre el perro perezoso");
                tree.Inorder(tree.ReturnRoot());
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
                CaminosMinimos Ruta = new CaminosMinimos();

                
                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5
                Console.WriteLine("\nA)");
                long[,] MatrizA =
                { { 999999999, 999999999, 999999999, 999999999, 1 },
                  { 1, 999999999, 1, 999999999, 999999999 },
                  { 999999999, 999999999, 999999999, 999999999 , 999999999 },
                  { 999999999, 1, 1, 999999999, 1 },
                  { 999999999,1,999999999,999999999,999999999 }};

                //Objeto de la clase
                
                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizA,5));

               
                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6
                Console.WriteLine("\nB)");
                long[,] MatrizB =
                { { 999999999, 999999999, 999999999, 999999999, 999999999, 1 },
                  { 1, 999999999, 999999999, 999999999, 999999999, 999999999 },
                  { 999999999, 1, 999999999, 1 , 999999999, 999999999},
                  { 999999999, 999999999, 999999999, 999999999, 1, 999999999 },
                  { 999999999,1,1,999999999,999999999,1 },
                  { 999999999,999999999,999999999,999999999,999999999,999999999} };

                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizB, 6));

                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g =  7, h = 8, i = 9
                Console.WriteLine("\nC)");
                long[,] MatrizC =
                { { 999999999, 999999999, 1,  999999999, 999999999, 999999999, 999999999, 999999999, 1 },
                  { 1, 999999999, 1, 999999999, 999999999, 999999999, 999999999, 1, 999999999 },
                  { 999999999, 999999999, 999999999, 999999999 , 999999999, 999999999, 999999999, 999999999, 999999999},
                  { 999999999, 1, 1, 999999999, 1, 999999999, 999999999, 999999999, 999999999 },
                  { 999999999,999999999, 999999999, 1, 999999999,999999999,999999999,999999999, 999999999},
                  { 999999999,999999999,999999999,1,1,999999999, 1, 999999999, 999999999},
                  { 999999999, 999999999, 1, 1, 999999999, 999999999, 999999999, 999999999, 999999999 },
                  { 999999999, 999999999, 999999999, 999999999, 999999999, 1, 1, 999999999, 1 },
                  { 1, 999999999, 999999999, 999999999, 999999999, 999999999, 1, 999999999, 999999999 } };

                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizC, 9));


            }

            if (opc == 10)
            {
                CaminosMinimos CM = new CaminosMinimos();
                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5
                Console.WriteLine("\nA)");
                long[,] MatrizA =
                { { 999999999, 1, 999999999, 1, 999999999 },
                  { 1, 999999999, 999999999, 999999999, 1 },
                  { 999999999, 1, 999999999, 999999999 , 999999999 },
                  { 1, 999999999, 999999999, 999999999, 999999999 },
                  { 999999999, 999999999, 1, 1,999999999 }};

                Console.WriteLine("Todos son circuitos...."); 

                CM.Circuitos(MatrizA, 1);
                CM.Circuitos(MatrizA, 2);
                CM.Circuitos(MatrizA, 3);
                CM.Circuitos(MatrizA, 4);
            }
        }
    }
}
