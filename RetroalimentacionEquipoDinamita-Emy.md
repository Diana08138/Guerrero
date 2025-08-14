# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

**Nombre del equipo que prueba:** _Equipo Dinamita__________________________  
**Nombre del equipo dueño del código:** _Diana Estefania CS____________________  
**Fecha:** _14/08/2025__________________

---

## 1. Datos generales del guerrero evaluado

| Atributo        | Valor |
|-----------------|-------|
| Nombre del guerrero |Hercules|
| Vida base       |100    |
| Ataque base     |15     |
| Defensa base    |1      |
| Velocidad       |No tiene|

---

## 2. Pruebas de combate con enemigos personalizados

Prueba el guerrero con enemigos que tengan distintos niveles de fuerza, vida y velocidad.

| Enemigo # | Vida | Ataque | Velocidad | ¿Ganó el guerrero? | Observaciones |
|-----------|------|--------|-----------|---------------------|----------------|
| 1 Poseidon|100   |15      |No tiene   |Si                   |La batalla es divertida e insentiva al jugador a tomar desiciones que lo pueden llevar a la victoria o a una derrota|
| 2         |      |        |           |                     |                |
| 3         |      |        |           |                     |                |
| 4         |      |        |           |                     |                |
| 5         |      |        |           |                     |                |

---

## 3. Evaluación del sistema de entrenamiento

### A. Entrenar fuerza

- ¿Aumenta la fuerza después de entrenar? ✅ 
- ¿Consume energía de forma proporcional a las horas? ✅   
- ¿El entrenamiento respeta el límite de 6 horas? ✅   
- Observaciones:  
La palabra fuerza no esta dentro del codigo, se cambia por experiencia  

### B. Entrenar resistencia

- ¿Aumenta la resistencia? ✅   
- ¿Afecta otras estadísticas? (por ejemplo, menos energía) ✅  
- ¿Tiene sentido el impacto por hora entrenada? ✅ 
- Observaciones:  
  Se tiene que entrar primero a la opcion de batalla para ganar la experiencia necesaria para entrenar la resistencia.

### C. Dormir / Descansar

- ¿Recupera energía al descansar? ❌  
- ¿Se evita sobrecargar la energía (por ejemplo, pasar de 100)? ✅  
- Observaciones:  
  No hay una opción para recuperar energia por descanso, pero si hay un limite para cuanto puedes entrenar

---

## 4. Progresión y balance

- ¿El personaje sube de nivel correctamente con la experiencia acumulada? ✅ 
- ¿Se siente balanceado el avance del personaje? ✅ 
- ¿Hay consecuencias claras si no tiene energía (por ejemplo, no puede entrenar)? ✅   
- Observaciones:  

---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                        | Cumple ✅ / ❌ | Comentarios |
|------------------------------------------------------------------|---------------|-------------|
| Menú interactivo con `switch` que se repite                     |      ❌        |Se usa if-else pero se puede adaptar a switch|
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)     |      ✅        |             |
| Uso de operadores aritméticos, lógicos y de comparación         |      ✅        |             |
| Condiciones para subir de nivel, agotarse o perder una batalla |       ✅        |             |
| Validaciones de energía y límites                               |      ✅        |             |
| Decisión del usuario sobre cuántas horas invertir por acción   |       ✅        |             |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)   |      ✅        |             |

---

## 6. Retroalimentación general

_Escribe aquí recomendaciones, mejoras o errores encontrados en la lógica del juego o en la estructura del código._  
-  
-  
-
