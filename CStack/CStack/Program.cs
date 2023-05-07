
using System.Collections.Concurrent;

ConcurrentStack<int> stack = new ConcurrentStack<int>();

// Agregamos algunos elementos a la pila concurrente
stack.Push(1);
stack.Push(2);
stack.Push(3);

// Creamos una tarea que agrega elementos a la pila
Task t1 = Task.Run(() =>
{
    for (int i = 4; i <= 6; i++)
    {
        stack.Push(i);
        Console.WriteLine("Elemento {0} agregado a la pila", i);
    }
});
Task.WaitAll(t1);
if (t1.IsCompleted) // Creamos otra tarea que elimina elementos de la pila
{
    Task t2 = Task.Run(() =>
    {
        int result;
        for (int i = 0; i < 3; i++)
        {
            if (stack.TryPop(out result))
            {
                Console.WriteLine("Elemento {0} eliminado de la pila", result);
            }
        }
    });
    Task.WaitAll(t2);// Esperamos a que ambas tareas terminen antes de continuar
}


// Task.WaitAll(t1, t2)hace las cosas a la misma vez.

// Mostramos los elementos restantes en la pila.
Console.WriteLine("Elementos restantes en la pila:");
foreach (int item in stack)
{
    Console.WriteLine(item);
}
