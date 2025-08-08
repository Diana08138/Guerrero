Algoritmo Guerrero_Hercules
  
  // Variables del guerrero Hercules
  ENTERO vidaHercules = 100
  ENTERO vidaMaximaHercules = 100
  ENTERO fuerzaHercules = 15
  ENTERO nivelHercules = 1
  ENTERO experienciaHercules = 0

  // Variables del enemigo Poseidon
  ENTERO vidaPoseidon = 100
  ENTERO fuerzaPoseidon = 15

  booleano juegoTerminado = FALSO
  ENTERO tiempoRecuperacion = 0
  ENTERO LIMITE_EXPERIENCIA_NIVEL_UP = 100

  // Bucle pirncipal

  FUNCION PRINCIPAL Main()
    ESCRIBIR "¡Bienvenido al juego!"
    MIENTRAS NO juegoTerminado
      MOSTRAR_MENU_PRINCIPAL()
    FINMIENTRAS
    ESCRIBIR "Saliendo del juego. ¡Hasta la proxima heroe!"
  FINFUNCION

  FUNCION MOSTRAR_ESTATUS_JUGADOR()
    ESCRIBIR "Este es el status de Hercules"
    ESCRIBIR "Nivel: " + nivelHercules
    ESCRIBIR "Experiencia: " + experienciaHercules + " / " + LIMITE_EXPERIENCIA_NIVEL_UP
    ESCRIBIR "Vida: " + vidaHercules + " / " + vidaMaximaHercules
    ESCRIBIR "Fuerza: " + fuerzaHercules
  FINFUNCION

  FUNCION MOSTRAR_MENU_PRINCIPAL()
    ESCRIBIR "MENÚ PRINCIPAL"
    ESCRIBIR "1. Que comience la batalla"
    ESCRIBIR "2. Conocer tu status"
    ESCRIBIR "3. Entrena la resistencia"
    ESCRIBIR "4. Salir del Juego"
    ESCRIBIR "Selecciona una opcion: "

    LEER opcionMenu

    SELECCIONAR CASO opcionMenu
      CASO 1:
        LOGICA_BATALLA()
      CASO 2:
        MOSTRAR_ESTATUS_JUGADOR()
        SUBIR_NIVEL()
      CASO 3:
        ENTRENAR_RESISTENCIA()
      CASO 4:
        juegoTerminado = VERDADERO
      POR DEFECTO:
        IMPRIMIR "Opcion no valida. Intente nuevamente"
    FINSELECCIONAR
  FINFUNCION

  FUNCION LOGICA_BATALLA()
    ESCRIBIR "¡Una nueva batalla comienza!"
    vidaPoseidon = 100

    MIENTRAS vidaHercules > 0 Y vidaPoseidon > 0
      ESCRIBIR "Tu Turno"
      ESCRIBIR "Vida del Guerrero: " + vidaHercules + " / " + vidaMaximaHercules
      ESCRIBIR "Vida del Enemigo: " + vidaPoseidon
      ESCRIBIR "1. Atacar"
      ESCRIBIR "2. Recuperarse (recupera 10 de vida)"
      ESCRIBIR "Selecciona una accion: "

      LEER opcionBatalla

      SELECCIONAR CASO opcionBatalla
        CASO 1:
          vidaPoseidon = vidaPoseidon - fuerzaHercules
          ESCRIBIR "Atacas al enemigo y le causas " + fuerzaHercules + " de daño."
        CASO 2:
          vidaHercules = vidaHercules + 10
          SI vidaHercules > vidaMaximaHercules ENTONCES
            ESCRIBIR "¡Tu vida esta al maximo! (" + vidaMaximaHercules + ")"
            vidaHercules = vidaMaximaHercules
          SINO
            ESCRIBIR "Te has recuperado. Tu vida actual es: " + vidaHercules
          FIN SI
          tiempoRecuperacion = 3
          ESCRIBIR "Hercules necesita " + tiempoRecuperacion + " turnos para recuperarse por completo."
        POR DEFECTO:
          ESCRIBIR "Accion no valida. Pierdes el turno."
      FINSELECCIONAR

      SI vidaPoseidon > 0 ENTONCES
        ESCRIBIR " Turno del Enemigo "
        SI tiempoRecuperacion == 0 ENTONCES
          vidaHercules = vidaHercules - fuerzaPoseidon
          ESCRIBIR "El enemigo te ataco y te causo " + fuerzaPoseidon + " de daño."
        SINO
          ESCRIBIR "El enemigo esta confundido. Pierde su turno."
        FINSI
      FINSI

      SI tiempoRecuperacion > 0 ENTONCES
        tiempoRecuperacion = tiempoRecuperacion - 1
        SI tiempoRecuperacion == 0 ENTONCES
          IMPRIMIR "El guerrero esta recuperado y listo para seguir la batalla."
        FINSI
      FINSI
    FIN MIENTRAS

    SI vidaHercules <= 0 ENTONCES
      ESCRIBIR "¡Te han derrotado!"
      juegoTerminado = VERDADERO
    SINO
      ESCRIBIR "\n¡Derrotaste al enemigo!"
      experienciaHercules = experienciaHercules + 50
      SUBIR_NIVEL()
    FINSI
  FIN FUNCION

  FUNCION SUBIR_NIVEL()
    SI experienciaHercules >= LIMITE_EXPERIENCIA_NIVEL_UP ENTONCES
      nivelHercules = nivelHercules + 1
      experienciaHercules = experienciaHercules - LIMITE_EXPERIENCIA_NIVEL_UP
      vidaMaximaHercules = vidaMaximaHercules * 1.2
      vidaHercules = vidaMaximaHercules
      fuerzaHercules = fuerzaHercules + 5
      ESCRIBIR "¡Felicidades! Has subido al nivel " + nivelHercules
      MOSTRAR_ESTATUS_JUGADOR()
    FINSI
  FIN FUNCION

  // Nuevo método para entrenar resistencia
  FUNCION ENTRENAR_RESISTENCIA()
    CONST COSTO_EXPERIENCIA_RESISTENCIA = 20
    CONST AUMENTO_VIDA_RESISTENCIA = 10

    ESCRIBIR " ENTRENAR RESISTENCIA "
    ESCRIBIR "Entrenar resistencia te cuesta " + COSTO_EXPERIENCIA_RESISTENCIA + " de experiencia y aumenta tu vida maxima en " + AUMENTO_VIDA_RESISTENCIA + " puntos."
    ESCRIBIR "Experiencia actual: " + experienciaHercules
    ESCRIBIR "Vida máxima actual: " + vidaMaximaHercules
    ESCRIBIR "¿Quieres entrenar? (S/N)"

    LEER respuesta

    SI respuesta ES IGUAL A "S" ENTONCES
      SI experienciaHercules >= COSTO_EXPERIENCIA_RESISTENCIA ENTONCES
        experienciaHercules = experienciaHercules - COSTO_EXPERIENCIA_RESISTENCIA
        vidaMaximaHercules = vidaMaximaHercules + AUMENTO_VIDA_RESISTENCIA
        vidaHercules = vidaHercules + AUMENTO_VIDA_RESISTENCIA
        ESCRIBIR "¡Entrenamiento exitoso! Tu vida máxima ahora es de " + vidaMaximaHercules + "."
        ESCRIBIR "Tu experiencia actual es de " + experienciaHercules + "."
      SINO
        ESCRIBIR "No tienes suficiente experiencia para entrenar."
      FINSI
    SINO
      ESCRIBIR "Has decidido no entrenar por ahora."
    FINSI
  FIN FUNCION

FIN ALGORITMO
