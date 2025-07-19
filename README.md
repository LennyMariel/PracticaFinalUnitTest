# ProyFinalAPITest

## Descripción del proyecto

Este proyecto automatiza pruebas funcionales para la API pública [FakeRestAPI](https://fakerestapi.azurewebsites.net/index.html) utilizando el framework de testing Karate.  
El propósito es validar todos los endpoints  `/Avtivities` , `/Authors`, `/Books`, `/CoverPhotos` y `/Users` y asegurar que la API cumpla con las reglas esperadas, incluyendo pruebas positivas y negativas (validación de campos obligatorios, respuestas correctas, etc.).

---

## Stack de tecnología

- **Java 11+** - Lenguaje de programación principal.  
- **Maven** - Gestor de proyectos y dependencias.  
- **Karate 1.4.1** - Framework de pruebas API basado en BDD con soporte para HTTP, JSON, y generación de reportes.  
- **JUnit 5** - Motor de ejecución de tests para Karate.  

---

## Pasos para ejecutar las pruebas automatizadas

1. Clonar el repositorio:

```bash
git clone https://github.com/TU_USUARIO/ProyFinalAPITest.git
cd ProyFinalAPITest

