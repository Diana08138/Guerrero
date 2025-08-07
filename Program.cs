using System;

public class Videojuego
{
    // Variables del guerrero Hercules
    static int vidaHercules = 100;
    static int vidaMaximaHercules = 100; 
    static int fuerzaHercules = 15;
    static int nivelHercules = 1;
    static int experienciaHercules = 0;

    // Variables del enemigo Poseidon
    static int vidaPoseidon = 100;
    static int fuerzaPoseidon = 15;

    static bool juegoTerminado = false;
    static int tiempoRecuperacion = 0;
    const int LIMITE_EXPERIENCIA_NIVEL_UP = 100;

    // Bucle principal del juego
    public static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego guererro!");

        while (!juegoTerminado)
        {
            MostrarMenuPrincipal();
        }

        Console.WriteLine("Saliendo del juego. ¡Hasta la proxima heroe!");
    }

    // Comienza el juego
    static void MostrarEstatusJugador()
    {
        Console.WriteLine("Este es el status de Hercules");
        Console.WriteLine($"Nivel: {nivelHercules}");
        Console.WriteLine($"Experiencia: {experienciaHercules} / {LIMITE_EXPERIENCIA_NIVEL_UP}");
        Console.WriteLine($"Vida: {vidaHercules} / {vidaMaximaHercules}"); // Mostrara la vida actual y maxima
        Console.WriteLine($"Fuerza: {fuerzaHercules}");
    }

    // Menu interactivo
    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("\n--- MENU PRINCIPAL ---");
        Console.WriteLine("1. Que comience la batalla");
        Console.WriteLine("2. Conoce tu status");
        Console.WriteLine("3. Entrena la resistencia"); 
        Console.WriteLine("4. Salir del Juego");
        Console.Write("Selecciona una opcion: ");

        if (int.TryParse(Console.ReadLine(), out int opcionMenu))
        {
            switch (opcionMenu)
            {
                case 1:
                    LogicaBatalla();
                    break;
                case 2:
                    MostrarEstatusJugador();
                    SubirNivel();
                    break;
                case 3:
                    EntrenarResistencia();
                    break;
                case 4:
                    juegoTerminado = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Intenta nuevamente");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no valida. Por favor, ingresa un numero.");
        }
    }

    // Logica de la batalla
    static void LogicaBatalla()
    {
        Console.WriteLine("\n¡Una nueva batalla comienza!");
        vidaPoseidon = 100; // Reinicia la vida de Poseidon para la batalla

        while (vidaHercules > 0 && vidaPoseidon > 0)
        {
            Console.WriteLine("\n--- Tu Turno ---");
            Console.WriteLine($"Vida del Guerrero: {vidaHercules} / {vidaMaximaHercules}");
            Console.WriteLine($"Vida del Enemigo: {vidaPoseidon}");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Recuperarse (recupera 10 de vida)");
            Console.Write("Selecciona una accion: ");

            if (int.TryParse(Console.ReadLine(), out int opcionBatalla))
            {
                switch (opcionBatalla)
                {
                    case 1:
                        // Operador aritmetico: resta
                        vidaPoseidon -= fuerzaHercules;
                        Console.WriteLine($"Atacas al enemigo y le causas {fuerzaHercules} de daño.");
                        break;
                    case 2:
                        // Operador aritmetico: suma
                        vidaHercules += 10;
                        // Se valida que la vida no exceda el limite
                        if (vidaHercules > vidaMaximaHercules)
                        {
                            Console.WriteLine($"¡Tu vida esta al maximo! ({vidaMaximaHercules})");
                            vidaHercules = vidaMaximaHercules;
                        }
                        else
                        {
                            Console.WriteLine("Te has recuperado. Tu vida actual es: " + vidaHercules);
                        }
                        // Recuperacion de Hercules
                        tiempoRecuperacion = 3;
                        Console.WriteLine($"Hercules necesita {tiempoRecuperacion} turnos para recuperarse por completo.");
                        break;
                    default:
                        Console.WriteLine("Accion no valida. Pierdes el turno.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Pierdes el turno.");
            }

            // Logica del turno del enemigo
            if (vidaPoseidon > 0)
            {
                Console.WriteLine("\n--- Turno del Enemigo ---");
                // El enemigo ataca si el guerrero no esta en recuperacion
                if (tiempoRecuperacion == 0)
                {
                    vidaHercules -= fuerzaPoseidon;
                    Console.WriteLine($"El enemigo te ataco y te causo {fuerzaPoseidon} de daño.");
                }
                else
                {
                    Console.WriteLine("El enemigo esta confundido. Pierde su turno.");
                }
            }

            // Validaciones
            if (tiempoRecuperacion > 0)
            {
                tiempoRecuperacion--;
                if (tiempoRecuperacion == 0)
                {
                    Console.WriteLine("El guerrero esta recuperado y listo para seguir en la batalla.");
                }
            }
        }

        // Resultados de la batalla
        if (vidaHercules <= 0)
        {
            Console.WriteLine("\n¡Te han derrotado!");
            juegoTerminado = true;
        }
        else
        {
            Console.WriteLine("\n¡Derrotaste al enemigo!");
            experienciaHercules += 50; // Operador aritmetico: suma
            SubirNivel();
        }
    }

    // Subir de nivel
    static void SubirNivel()
    {
        // Operador de comparacion: Mayor o igual que
        if (experienciaHercules >= LIMITE_EXPERIENCIA_NIVEL_UP)
        {
            // Operadores aritmeticos y logicos
            nivelHercules++;
            experienciaHercules -= LIMITE_EXPERIENCIA_NIVEL_UP;
            vidaMaximaHercules = (int)(vidaMaximaHercules * 1.2); // Aumentara la vida maxima
            vidaHercules = vidaMaximaHercules; // Restablecer la vida al maximo
            fuerzaHercules += 5; // Aumenta 5 puntos de fuerza
            Console.WriteLine("\n¡Felicidades! Subiste de nivel " + nivelHercules);
            MostrarEstatusJugador();
        }
    }

    // Metodo para entrenar resistencia
    static void EntrenarResistencia()
    {
        const int COSTO_EXPERIENCIA_RESISTENCIA = 20;
        const int AUMENTO_VIDA_RESISTENCIA = 10;

        Console.WriteLine("\n--- ENTRENAR RESISTENCIA ---");
        Console.WriteLine($"Entrenar la resistencia cuesta: {COSTO_EXPERIENCIA_RESISTENCIA} de experiencia y aumenta la vida maxima {AUMENTO_VIDA_RESISTENCIA} puntos.");
        Console.WriteLine($"Experiencia actual: {experienciaHercules}");
        Console.WriteLine($"Vida maxima actual: {vidaMaximaHercules}");
        Console.WriteLine("¿Quieres entrenar? (S/N)");

        string respuesta = Console.ReadLine().Trim().ToUpper();

        if (respuesta == "S")
        {
            if (experienciaHercules >= COSTO_EXPERIENCIA_RESISTENCIA)
            {
                experienciaHercules -= COSTO_EXPERIENCIA_RESISTENCIA;
                vidaMaximaHercules += AUMENTO_VIDA_RESISTENCIA;
                vidaHercules += AUMENTO_VIDA_RESISTENCIA; // Aumentar vida actual al entrenar
                Console.WriteLine($"¡Que buen entrenamiento! La vida maxima: {vidaMaximaHercules}.");
                Console.WriteLine($"Tu experiencia actual es: {experienciaHercules}.");
            }
            else
            {
                Console.WriteLine("Insuficiente experiencia para el entrenamiento.");
            }
        }
        else
        {
            Console.WriteLine("Has decidido no entrenar por ahora, descansa.");
        }
    }
}
