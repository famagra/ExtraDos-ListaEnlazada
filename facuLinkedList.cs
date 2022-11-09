using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlasada
{
    internal class facuLinkedList
    {
        Node head; //el primer nodo
        int total; // el tamaño de la lista

        //constructor de la clase facuLinkedList inicializado
        public facuLinkedList()
        {
            this.head = null;
            this.total = 0;
        }

        //metodo agregar nodo
        public void add(int data)
        {
            
            Node newNode = new Node(data);
            newNode.next = null;

            if (this.head == null)
            {
                //no habia elementos en lista y lo agrega
                head = newNode;
            }
            else
            {
                Node ultimo = ultimoNodo();
                ultimo.next = newNode;
            }
            this.total++;
        }

        //funcionar para buscar ultimo nodo
        public Node ultimoNodo()
        {
            if (this.head == null)
            {
                return null;
            }

            Node ultimo = this.head;
            Node aux = this.head;

            while(aux != null)
            {
                ultimo = aux;
                aux = ultimo.next;
            }

            return ultimo;
        }

        //imprimir
        public void print()
        {
            Node node = this.head;

            while(node != null)
            {
                Console.Write("*" + node.data);
                node = node.next;
            }
        }

        //metodo para agregar en una posicion
        public void addPos(Node node, int data)
        {
            if (this.head == null || node == null) return;

            Node newNodo = new Node(data);
            
            Node previo = node;
            Node next = node.next;

            //hacemos la asignación que seria como el cambio de variables

            previo.next = newNodo;
            newNodo.next = next;
            this.total++;


        }

        //funcion para buscar la posición del nodo y la usamos para eliminar o agregar nodo.
        public Node posicion(int pos)
        {
            if (this.head == null || (this.total - 1) < pos) return null;

            Node aux = this.head;
            int x = 0;

            while(aux != null)
            {
                if (x == pos) break;
                x++;
                aux = aux.next;

            }
            return aux;
        }

        
        //metodo para borrar nodo
        public void delete (Node node)
        {
            if(this.head == null || node == null) return;
            Node aux = this.head;
            Node temporal = null;

            if (node == head)
            {
                //borramos el primero
                temporal = head;
                this.head = this.head.next;

                temporal = null;
            }
            else
            {
                //se elimina otr nodo
                while(aux.next != node)
                {
                    aux=aux.next;
                }
                //asignaciones de nodos
                temporal = aux.next;
                aux.next = temporal.next;
                temporal = null;

            }
            //decrementamos la lista
            this.total--;
        }

        //se crea la clase Node y el constructor
        public class Node
        {
            public int data;
            public Node next;

            //constructor de la clase node
            public Node(int data)
            {
                this.data=data;
                this.next = next;
            }

        }

        
    }
}
