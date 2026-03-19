# Implementación del Patrón de Diseño Composite en C#

## Información de la práctica

| Dato                | Información          |
| ------------------- | -------------------- |
| Alumno              | Rodrigo Sotelo Rubio |
| Número de control   | 21212053             |
| Materia             | Patrones de Diseño   |
| Lenguaje utilizado  | C#                   |
| Tipo de patrón      | Patrón Estructural   |
| Patrón implementado | Composite            |

---

## Descripción de la práctica

En esta práctica se implementa el patrón de diseño Composite utilizando el lenguaje C#. El objetivo es demostrar cómo se pueden representar estructuras jerárquicas en forma de árbol, permitiendo tratar de la misma manera tanto a objetos individuales como a conjuntos de objetos.

El contexto del problema se basa en el armado de computadoras, donde una computadora está compuesta por distintos componentes, los cuales pueden ser piezas individuales o agrupaciones de componentes.

Entre los elementos utilizados se encuentran:

- Computadora (estructura principal)
- Motherboard
- Almacenamiento
- Procesador (CPU)
- Memoria RAM
- GPU
- SSD / HDD
- Fuente de poder

Gracias al patrón Composite, se pueden organizar estos elementos en una estructura jerárquica donde cada componente puede ser tratado de forma uniforme.

---

## ¿Qué es el patrón Composite?

El patrón Composite es un patrón de diseño estructural que permite componer objetos en estructuras de árbol para representar jerarquías parte-todo.

Este patrón permite que los clientes traten de manera uniforme tanto a los objetos individuales como a los compuestos.

---

## Características principales

- Permite representar estructuras jerárquicas.
- Trata de forma uniforme objetos simples y compuestos.
- Facilita el uso de recursividad.
- Mejora la escalabilidad del sistema.
- Permite agregar nuevos componentes fácilmente.

---

## Implementación en el programa

En el programa se creó una clase abstracta llamada:

**Componente**

Esta clase define la estructura base y contiene los métodos:

- AgregarHijo()
- ObtenerHijos()
- ObtenerCosto

Posteriormente se implementaron dos clases principales:

### Ensamble (Composite)

Representa un conjunto de componentes. Puede contener otros ensamblajes o piezas, y su costo se calcula sumando el costo de todos sus hijos.

### Pieza (Leaf)

Representa un componente individual. No tiene hijos y su costo es fijo.

---

## Computadoras implementadas

Se crearon tres tipos de computadoras:

- PC Gamer
- PC Oficina
- PC Estudiante

Cada una contiene al menos cinco componentes y algunas incluyen subensambles como:

- Motherboard
- Almacenamiento

Esto permite representar una estructura jerárquica real.

---

## ▶️ Ejecución del programa

Para ejecutar el proyecto desde la terminal se utiliza el siguiente comando:

```bash
dotnet run
```

El programa calcula y muestra el costo total de cada computadora, sumando de manera recursiva todos sus componentes.

---

## 🧾 Conclusión

Durante el desarrollo de esta práctica pude comprender cómo funciona el patrón de diseño Composite y cómo puede aplicarse para representar estructuras jerárquicas en forma de árbol. Este patrón permite tratar de manera uniforme tanto a los objetos individuales como a los compuestos, lo cual facilita el manejo de estructuras complejas.

En el caso del armado de computadoras, se logró representar cada equipo como un conjunto de componentes, donde algunos de ellos pueden contener otros elementos. Gracias a esto, el cálculo del costo total se realiza de forma recursiva, haciendo que el código sea más flexible, reutilizable y fácil de mantener.
