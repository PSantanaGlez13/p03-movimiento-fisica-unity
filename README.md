# p03-movimiento-fisica-unity
- Pablo Santana González alu0101480541@ull.edu.es
-----------------------------------------------
# Física
## Situación 1

Como podemos ver, el cubo no atraviesa el plano. Esto se debe a que el plano es un static collider que, al entrar en contacto con el Rigidbody collider, detecta la colisión y evita que continue.

![Fisica 1](media/Fisica-1)

## Situación 2

La esfera cae ya que ahora tiene rigidbody y es considerada para la simulación de físicas.

![Fisica 2](media/Fisica-2)

## Situación 3

La esfera, al ser kinematic, no es afectada por la simulación de físicas.

![Fisica 3](media/Fisica-3)

## Situación 4

Al asignarle un Rigidbody al plano para que sea físico, podemos ver como el plano, la esfera y el cubo caen al vacío. Esto pasa en el resto de ejercicios de ahora en adelante si pusieramos el plano como un objeto con rigidbody normal.

![Fisica 4](media/Fisica-4-segun-enunciado)

Para solventar esto, de ahora en adelante usaremos un plano con rigidbody, pero sera kinetic.

## Situación 5

Podemos ver que el cubo se mueve un poco cuando colisiona la esfera.

![Fisica 5](media/Fisica-5)

## Situación 6

Podemos ver que el cubo se mueve mucho más que en la situación anterior.

![Fisica 6](media/Fisica-6)

## Situación 7

A causa del material con fricción, la esfera se desplaza más lentamente, aunque es poco visible. En el ejercicio 12 del apartado de movimiento veremos un ejemplo en el que esta diferencia es más notable.

![Fisica 7](media/Fisica-7)

## Situación 8

Como la esfera es un trigger y no es físico, no le afecta la gravedad y se queda levitando.

![Fisica 8](media/Fisica-8)

## Situación 9

Al ser física, la esfera es afectada por la gravedad. Pero al ser un trigger, no se tiene en cuenta para la simulación de físicas (al menos en las colisiones) y por eso el plano no la para de caer al vacío.

![Fisica 9](media/Fisica-9)

# Movimiento
## Ejercicio 1

## Ejercicio 2

## Ejercicio 3

## Ejercicio 4

## Ejercicio 5

## Ejercicio 6

## Ejercicio 7

## Ejercicio 8

## Ejercicio 9

## Ejercicio 10

## Ejercicio 11

## Ejercicio 12
