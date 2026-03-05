# Patrones-de-diseno

# Patrón de Diseño: Abstract Factory en C#

## Rodrigo Sotelo Rubio - 21212053

## Descripción

Este proyecto muestra una implementación del **patrón de diseño Abstract Factory** utilizando **C#**.
El objetivo del patrón es **crear familias de objetos relacionados sin especificar sus clases concretas**, permitiendo que el código sea más flexible y fácil de mantener.

En este ejemplo se simula un sistema que genera **material educativo** dependiendo de la modalidad de estudio.

Las modalidades implementadas son:

- **Presencial**
- **Virtual**
- **Híbrida**

Cada modalidad genera dos elementos relacionados:

- Una **Guía de estudio**
- Un **Examen**

---

## Estructura del Proyecto

El sistema está organizado de la siguiente manera:

### Productos Abstractos

- `Guia`
- `Examen`

Estas clases definen las operaciones comunes que deben implementar las clases concretas.

### Productos Concretos

**Modalidad Presencial**

- `GuiaImpresa`
- `ExamenEnPapel`

**Modalidad Virtual**

- `GuiaPDF`
- `ExamenOnline`

**Modalidad Híbrida**

- `GuiaHibrida`
- `ExamenMixto`

### Fábrica Abstracta

- `MaterialFactory`

Define los métodos para crear los productos:

- `CrearGuia()`
- `CrearExamen()`

### Fábricas Concretas

- `MaterialPresencialFactory`
- `MaterialVirtualFactory`
- `MaterialHibridoFactory`

Cada fábrica crea los objetos correspondientes a su modalidad.

---

## Funcionamiento

El programa principal selecciona una fábrica dependiendo de la modalidad.
La fábrica se encarga de crear los objetos correspondientes (guía y examen).

Esto permite cambiar el comportamiento del sistema **sin modificar el código principal**, simplemente utilizando otra fábrica.

---

## Ejemplo de Salida

Mostrando la guia impresa
Se aplica examen en papel

Mostrando la guia PDF
Se aplica examen en linea

Mostrando la guia en modalidad hibrida (semipresencial)
Se aplica examen mixto (parte en linea y parte presencial)

---

## Ventajas del Patrón

- Reduce el **acoplamiento** entre clases.
- Facilita la **extensión del sistema**.
- Permite trabajar con **familias de objetos relacionadas**.
- Hace que el código sea **más organizado y mantenible**.

---

## Tecnologías Utilizadas

- C#
- .NET
- Programación Orientada a Objetos

---

## Autor

Proyecto realizado como práctica académica para comprender la implementación del patrón de diseño **Abstract Factory**.
