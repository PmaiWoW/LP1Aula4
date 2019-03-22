using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            int numNPCs, check;
            NPCPerk[] caract;

            //pedir o número de npcs ao utilizador
            Console.WriteLine("Quantos NPCs serão criados");
            //converter o input num int
            numNPCs = Convert.ToInt32(Console.ReadLine());

            caract = new NPCPerk[numNPCs];

            //pergunta, para cada característica possível se o npc a tem, 
            //adicionando a mesma a esse npc no array que contém todos os npcs
            for (int i = 0; i < numNPCs; i++)
            {
                Console.WriteLine($"O NPC {i+1} tem a característica Stealth?"+
                    $"0 - Não, 1 - Sim");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    caract[i] |= NPCPerk.Stealth;
                }

                Console.WriteLine($"O NPC {i+1} tem a característica Combat?" +
                    $"0 - Não, 1 - Sim");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    caract[i] |= NPCPerk.Combat;
                }

                Console.WriteLine($"O NPC {i+1} tem a característica" +
                    $" Lockpick? 0 - Não, 1 - Sim");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    caract[i] |= NPCPerk.LockPick;
                }

                Console.WriteLine($"O NPC {i+1} tem a característica Luck? " +
                    $"0 - Não, 1 - Sim");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    caract[i] |= NPCPerk.Luck;
                }
            }
            
            for (int i = 0; i < numNPCs; i++)
            {
                Console.WriteLine($"NPC {i+1}: {caract[i]}");
                if ((caract[i] & (NPCPerk.Combat | NPCPerk.Luck)) ==
                    (NPCPerk.Combat | NPCPerk.Luck))
                {
                    Console.WriteLine("You Shall win all fights!\n");
                }
            }

            Console.ReadKey();
        }
    }
}
