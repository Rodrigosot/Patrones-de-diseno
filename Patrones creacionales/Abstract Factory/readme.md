# Implementación del Patrón de Diseño Abstract Factory en C#

---

## Información de la práctica

| Dato                    | Información          |
| ----------------------- | -------------------- |
| **Alumno**              | Rodrigo Sotelo Rubio |
| **Número de control**   | 21212053             |
| **Materia**             | Patrones de Diseño   |
| **Lenguaje utilizado**  | C#                   |
| **Tipo de patrón**      | Patrón Creacional    |
| **Patrón implementado** | Abstract Factory     |

---

## Descripción de la práctica

En esta práctica se implementa el **patrón de diseño Abstract Factory** utilizando el lenguaje **C#**.

El objetivo de este patrón es permitir la creación de **familias de objetos relacionados** sin especificar sus clases concretas. Esto permite que el sistema sea más flexible y que el código esté menos acoplado.

El contexto del problema simula la generación de **material académico y evaluaciones para diferentes modalidades educativas** dentro de un instituto.

Las modalidades consideradas son:

- Modalidad **Presencial**
- Modalidad **Virtual**
- Modalidad **Híbrida**

Cada modalidad genera su propio conjunto de materiales, como:

- Guías de estudio
- Exámenes

Gracias al patrón **Abstract Factory**, es posible crear estos objetos sin que el programa principal conozca las clases específicas que se están utilizando.

---

## ¿Qué es el patrón Abstract Factory?

El patrón **Abstract Factory** es un patrón de diseño **creacional** que proporciona una interfaz para crear **familias de objetos relacionados o dependientes**, sin especificar sus clases concretas.

Este patrón es útil cuando un sistema debe ser independiente de cómo se crean, componen y representan los objetos que utiliza.

### Características principales

- Permite crear familias de objetos relacionados.
- Reduce el acoplamiento entre clases.
- Facilita el cambio de implementaciones.
- Mejora la organización del código.

---

## Implementación en el programa

En el programa se creó una **fábrica abstracta** llamada:

```id="xrt7ac"
MaterialFactory
```

Esta fábrica define los métodos para crear los diferentes productos del sistema.

```id="q2o1yq"
public abstract Guia CrearGuia();
public abstract Examen CrearExamen();
```

---

### 🧩 Productos abstractos

Se definieron dos productos principales:

- **Guia**
- **Examen**

Cada uno con su comportamiento específico.

---

### Productos concretos

Dependiendo de la modalidad educativa, se generan diferentes implementaciones:

**Modalidad Presencial**

- GuiaImpresa
- ExamenEnPapel

**Modalidad Virtual**

- GuiaPDF
- ExamenOnline

**Modalidad Híbrida**

- GuiaHibrida
- ExamenMixto

---

### Fábricas concretas

Cada modalidad tiene su propia fábrica:

- `MaterialPresencialFactory`
- `MaterialVirtualFactory`
- `MaterialHibridoFactory`

Cada una crea los productos correspondientes a su modalidad.

---

## Ejecución del programa

Para ejecutar el proyecto desde la terminal se utiliza el siguiente comando:

```bash id="b7b7ze"
dotnet run
```

El programa mostrará en consola la creación de los materiales académicos dependiendo de la modalidad seleccionada.

Ejemplo de salida:

```id="kk4t5d"
Mostrando la guia impresa
Se aplica examen en papel

Mostrando la guia PDF
Se aplica examen en linea

Mostrando la guia en modalidad hibrida (semipresencial)
Se aplica examen mixto (parte en linea y parte presencial)
```

---

## 🧾 Conclusión

Durante el desarrollo de esta práctica se pudo comprender cómo funciona el patrón de diseño Abstract Factory y su utilidad para crear familias de objetos relacionados dentro de un sistema. Este patrón permite organizar mejor la creación de objetos y separar la lógica de instanciación del resto del código.

En el contexto del programa, cada modalidad educativa (presencial, virtual o híbrida) puede generar su propio conjunto de materiales como guías y exámenes. Gracias al uso de fábricas, el programa principal no necesita conocer las clases específicas que se están utilizando, lo que hace que el sistema sea más flexible y fácil de mantener.
