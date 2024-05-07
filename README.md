# Práctica principios S.O.L.I.D.

Indique qué principio/s SOLID y/o buenas prácticas del desarrollo de software no se cumplen y modifique el programa para que sí los cumpla.

Deficiencias identificadas.

La clase Tren tiene el método Volar el cual no utiliza debido a su condición (un tren claramente no puede volar). No se respeta el Principio de Única Responsabilidad. 

No se respeta el principio de ISP, por lo qué se genero una interfaz que puede interpretar Volar para segregar en la nueva interfaz, que esta pueda interpretar Volar.
