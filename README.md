# p03-movimiento-fisica-unity
- Pablo Santana González alu0101480541@ull.edu.es
-----------------------------------------------
# Física
## Situación 1

Como podemos ver, el cubo no atraviesa el plano. Esto se debe a que el plano es un static collider que, al entrar en contacto con el Rigidbody collider, detecta la colisión y evita que continue.

![Fisica 1](media/Fisica-1.gif)

## Situación 2

La esfera cae ya que ahora tiene rigidbody y es considerada para la simulación de físicas.

![Fisica 2](media/Fisica-2.gif)

## Situación 3

La esfera, al ser kinematic, no es afectada por la simulación de físicas.

![Fisica 3](media/Fisica-3.gif)

## Situación 4

Al asignarle un Rigidbody al plano para que sea físico, podemos ver como el plano, la esfera y el cubo caen al vacío. Esto pasa en el resto de ejercicios de ahora en adelante si pusieramos el plano como un objeto con rigidbody normal.

![Fisica 4](media/Fisica-4-segun-enunciado.gif)

Para solventar esto, de ahora en adelante usaremos un plano con rigidbody, pero sera kinetic.

## Situación 5

Podemos ver que el cubo se mueve un poco cuando colisiona la esfera.

![Fisica 5](media/Fisica-5.gif)

## Situación 6

Podemos ver que el cubo se mueve mucho más que en la situación anterior.

![Fisica 6](media/Fisica-6.gif)

## Situación 7

A causa del material con fricción, la esfera se desplaza más lentamente, aunque es poco visible. En el ejercicio 12 del apartado de movimiento veremos un ejemplo en el que esta diferencia es más notable.

![Fisica 7](media/Fisica-7.gif)

## Situación 8

Como la esfera es un trigger y no es físico, no le afecta la gravedad y se queda levitando.

![Fisica 8](media/Fisica-8.gif)

## Situación 9

Al ser física, la esfera es afectada por la gravedad. Pero al ser un trigger, no se tiene en cuenta para la simulación de físicas (al menos en las colisiones) y por eso el plano no la para de caer al vacío.

![Fisica 9](media/Fisica-9.gif)

# Movimiento
## Ejercicio 1
Como se puede ver, al pulsar una tecla se indica por pantalla el nombre de dicha tecla así como el valor de multiplicar el valor del eje sobre el que se está interactuando por la velocidad indicada.

![Movimiento 1](media/Movimiento-1.gif)

```c#
    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("Horizontal");
        if (movimiento_horizontal > 0) {
            Debug.Log("Presionada flecha derecha. Eje Horizontal: " + movimiento_horizontal * velocidad);
        } else if (movimiento_horizontal < 0) {
            Debug.Log("Presionada flecha izquierda. Eje Horizontal: " + movimiento_horizontal * velocidad);
        }

        float movimiento_vertical = Input.GetAxis("Vertical");
        if (movimiento_vertical > 0) {
            Debug.Log("Presionada flecha arriba. Eje Vertical: " + movimiento_vertical * velocidad);
        } else if (movimiento_vertical < 0) {
            Debug.Log("Presionada flecha abajo. Eje Vertical: " + movimiento_vertical * velocidad);
        }
    }
```

## Ejercicio 2

Para este ejercicio, vamos al apartado de `Project Settings` y luego al de `Input Manager`. Buscamos el eje de disparar (he usado `Fire 1`) y le asignamos al botón positivo la h. 

![Movimiento 2](media/Movimiento-2.PNG)

## Ejercicio 3


![Movimiento 3](media/Movimiento-3.gif)

## Ejercicio 4

![Movimiento 4](media/Movimiento-4.gif)

## Ejercicio 5

![Movimiento 5](media/Movimiento-5.gif)

## Ejercicio 6

![Movimiento 6](media/Movimiento-6.gif)

## Ejercicio 7

![Movimiento 7](media/Movimiento-7.gif)

## Ejercicio 8

![Movimiento 8](media/Movimiento-8.gif)

## Ejercicio 9

![Movimiento 9](media/Movimiento-9.gif)

## Ejercicio 10

![Movimiento 10](media/Movimiento-10.gif)

## Ejercicio 11

![Movimiento 11](media/Movimiento-11.gif)

## Ejercicio 12

![Movimiento 12](media/Movimiento-12.gif)

