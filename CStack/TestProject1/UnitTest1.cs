using System.Collections.Concurrent;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TareasSimultaneasOrdenadas()
        {

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
            Assert.Equal(6, stack.Count());
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
                Assert.True(t1.IsCompleted);
                Assert.True(t2.IsCompleted);
                Assert.Equal(3, stack.Count());
            }
           
        }
        [Fact]
        public void TareasSimultaneas()
        {

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
                }
            });
            Assert.Equal(6, stack.Count());
            
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
                Task.WaitAll(t1,t2);// Esperamos a que ambas tareas terminen antes de continuar
                Assert.True(t1.IsCompleted);
                Assert.True(t2.IsCompleted);
                Assert.Equal(3, stack.Count());
            }
        }
}