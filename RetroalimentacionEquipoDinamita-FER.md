# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

**Nombre del equipo que prueba:** FerRC-Axl 
**Nombre del equipo dueño del código:** Diana08138  
**Fecha:** 07/08/2025

---

## 1. Datos generales del guerrero evaluado

| Atributo            | Valor       |
|---------------------|-------------|
| Nombre del guerrero | Hércules    |
| Vida base           | 100         |
| Ataque base         | 15          |
| Defensa base        | No definida |
| Velocidad           | No definida |

---

## 2. Pruebas de combate con enemigos personalizados

> El código solo implementa un enemigo fijo (Poseidón).

| Enemigo # | Vida | Ataque | Velocidad | ¿Ganó el guerrero? | Observaciones                               |
|-----------|------|--------|-----------|---------------------|----------------------------------------------|
| 1         | 100  | 15     | -         | ✅                   | Poseidón es el único enemigo implementado.   |
| 2         | 120  | 20     | -         | ❌/✅ (requiere código extra) | No hay soporte para enemigos distintos.       |
| 3         | 50   | 10     | -         | ✅                   | Solo si se modifica el código base.          |
| 4         | 200  | 25     | -         | ❌                   | No hay mecánica de velocidad, solo fuerza.   |
| 5         | 80   | 5      | -         | ✅                   | Se gana fácilmente, pero no es configurable. |

---

## 3. Evaluación del sistema de entrenamiento

### A. Entrenar fuerza

- ¿Aumenta la fuerza después de entrenar? ❌  
- ¿Consume energía de forma proporcional a las horas? ❌  
- ¿El entrenamiento respeta el límite de 6 horas? ❌  
- **Observaciones:**  
  Actualmente no existe una función para entrenar la fuerza. Solo se incrementa automáticamente al subir de nivel.

### B. Entrenar resistencia

- ¿Aumenta la resistencia? ✅  
- ¿Afecta otras estadísticas? (por ejemplo, menos energía) ❌  
- ¿Tiene sentido el impacto por hora entrenada? ❌  
- **Observaciones:**  
  El entrenamiento aumenta la vida máxima en +10 a cambio de 20 puntos de experiencia, pero no está vinculado a horas ni energía, y es un proceso inmediato.

### C. Dormir / Descansar

- ¿Recupera energía al descansar? ❌  
- ¿Se evita sobrecargar la energía (por ejemplo, pasar de 100)? ❌  
- **Observaciones:**  
  El juego no implementa un sistema de energía ni de descanso como tal. Se puede recuperar vida durante la batalla, pero no existe una mecánica de descanso fuera del combate.

---

## 4. Progresión y balance

- ¿El personaje sube de nivel correctamente con la experiencia acumulada? ✅  
- ¿Se siente balanceado el avance del personaje? ✅  
- ¿Hay consecuencias claras si no tiene energía (por ejemplo, no puede entrenar)? ❌  
- **Observaciones:**  
  La progresión está bien diseñada con un sistema de experiencia y mejora de estadísticas, pero no hay sistema de energía ni gestión de recursos más allá de la vida.

---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                        | Cumple ✅ / ❌ | Comentarios                                           |
|------------------------------------------------------------------|---------------|--------------------------------------------------------|
| Menú interactivo con `switch` que se repite                     | ✅            | Bien implementado en `MostrarMenuPrincipal()`.        |
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)     | ✅            | Aunque no hay `EntrenarFuerza`, las actividades están separadas. |
| Uso de operadores aritméticos, lógicos y de comparación         | ✅            | Se usan correctamente.                                |
| Condiciones para subir de nivel, agotarse o perder una batalla | ✅            | Correctamente aplicado.                               |
| Validaciones de energía y límites                               | ❌            | No hay sistema de energía implementado.               |
| Decisión del usuario sobre cuántas horas invertir por acción   | ❌            | No hay control de horas o tiempo entrenando.          |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)   | ✅            | Uso adecuado de `if`, `switch` y bucles.              |

---

## 6. Retroalimentación general

- El código está muy bien estructurado para un nivel básico o medio. La lógica de batalla es clara y fácil de seguir.   
- Se recomienda implementar un sistema de **energía**, que se consuma al entrenar, luchar o realizar acciones. Esto daría más profundidad estratégica al juego.  
- Sería ideal agregar una función para **entrenar fuerza**.  
- Falta desarrollar las estadísticas de **defensa y velocidad**, lo cual haría los combates más variados y permitiría diferenciar enemigos.  
- El juego podría beneficiarse de un sistema de enemigos **aleatorio**, en lugar de un solo enemigo fijo.  
- Incluir el **tiempo** como recurso (horas de entrenamiento, turnos, días) permitiría incorporar decisiones más complejas y realistas.  
