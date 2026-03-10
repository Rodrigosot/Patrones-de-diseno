# Implementación del Patrón de Diseño Prototype en C#

---

## Información de la práctica

| Dato                    | Información          |
| ----------------------- | -------------------- |
| **Alumno**              | Rodrigo Sotelo Rubio |
| **Número de control**   | 21212053             |
| **Materia**             | Patrones de Diseño   |
| **Lenguaje utilizado**  | C#                   |
| **Tipo de patrón**      | Patrón Creacional    |
| **Patrón implementado** | Prototype            |

---

## Descripción de la práctica

En esta práctica se implementa el **patrón de diseño Prototype** utilizando el lenguaje **C#**.
El objetivo es demostrar cómo se pueden crear nuevos objetos mediante la **clonación de un objeto existente**, evitando crear cada instancia desde cero.

El contexto del problema se basa en la creación de **exámenes para diferentes materias dentro de un instituto**.
Un mismo docente puede impartir la misma asignatura a distintos grupos, por lo que muchos atributos del examen se comparten.

Entre los atributos compartidos se encuentran:

- Clave de la materia
- Nombre de la asignatura
- Docente
- Salón
- Grupo

Gracias al patrón **Prototype**, se puede crear un **examen base** y posteriormente **clonarlo** para generar nuevos exámenes para otros grupos o materias.

---

## ¿Qué es el patrón Prototype?

El patrón **Prototype** es un patrón de diseño **creacional** que permite crear nuevos objetos copiando un objeto existente, conocido como **prototipo**.

En lugar de crear un objeto desde cero, se realiza una **clonación del objeto base**, lo cual permite reutilizar su estructura y modificar únicamente los atributos necesarios.

### Características principales

- Permite crear objetos mediante clonación.
- Reduce la duplicación de código.
- Facilita la reutilización de objetos existentes.
- Mejora la flexibilidad al crear instancias.

---

## Implementación en el programa

En el programa se creó una clase abstracta llamada:

```id="kq5d1x"
ExamenPrototype
```

Esta clase contiene los atributos comunes de un examen y un método abstracto llamado:

```id="3j44ea"
Clonar()
```

Posteriormente se implementaron diferentes tipos de exámenes que heredan de esta clase.

### Materias implementadas

- Patrones de Diseño
- Programación
- Base de Datos
- Redes de Computadoras
- Sistemas Operativos
- Inteligencia Artificial
- Ingeniería de Software
- Seguridad Informática

Cada una de estas clases implementa el método **Clonar()**, el cual permite duplicar el objeto utilizando:

```id="49pbwy"
MemberwiseClone()
```

---

## ▶️ Ejecución del programa

Para ejecutar el proyecto desde la terminal se utiliza el siguiente comando:

```bash id="4egcsf"
dotnet run
```

El programa crea un examen base y posteriormente genera otro examen mediante clonación.

## 🧾 Conclusión

Durante el desarrollo de esta práctica pude comprender cómo funciona el patrón de diseño Prototype y cómo puede aplicarse para crear objetos de manera más eficiente. Este patrón permite generar nuevas instancias a partir de la clonación de un objeto existente, lo cual reduce la duplicación de código y facilita la reutilización de estructuras.

En el caso del sistema de exámenes, se puede crear un examen base para una materia específica y posteriormente clonarlo para otros grupos que cursen la misma asignatura. De esta manera se aprovechan los atributos compartidos y solo se modifican los datos necesarios, logrando que el código sea más organizado y fácil de mantener.
