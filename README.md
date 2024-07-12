<img src="media/image1.jpeg" style="width:5.24167in;height:2.65833in"
alt="https://www.vectorlogo.es/wp-content/uploads/2014/12/logo-vector-universidad-rey-juan-carlos.jpg" />

**ESCUELA TÉCNICA SUPERIOR DE INGENIERÍA INFORMÁTICA**

**GRADO EN DISEÑO Y DESARROLLO DE VIDEOJUEGOS**

**Curso Académico 2023/2024**

**Trabajo Fin de Grado**

**Karu Racing: simulador de coches Simcade con físicas y modelos de
coches reales**

> **Autor**: Jorge Cambero Mogena
>
> **Directores**: Carlos Garre Del Olmo

“Quiero agradecer a mi familia el apoyo en estos últimos meses, a mi
padre y mi tío Ramón por inculcarme la afición por el automovilismo y la
Formula 1 y a mi mascota Petri”

# Índice 

[Índice [2](#_Toc171504677)](#_Toc171504677)

[Tabla de ilustraciones
[4](#tabla-de-ilustraciones)](#tabla-de-ilustraciones)

[Tabla de código [6](#tabla-de-código)](#tabla-de-código)

[Tabla de Graficas [8](#tabla-de-graficas)](#tabla-de-graficas)

[1. Resumen [9](#resumen)](#resumen)

[2. Abstract [10](#abstract)](#abstract)

[1. Introducción [11](#introducción)](#introducción)

[1.1. Descripción del problema
[11](#descripción-del-problema)](#descripción-del-problema)

[1.2. Motivación [11](#motivación)](#motivación)

[1.3. Objetivos [11](#objetivos)](#objetivos)

[1.3.1. Objetivo principal
[11](#objetivo-principal)](#objetivo-principal)

[1.3.2. Objetivos secundarios
[12](#objetivos-secundarios)](#objetivos-secundarios)

[1.4. Metodología [12](#metodología)](#metodología)

[1.5. Estructura del documento
[13](#estructura-del-documento)](#estructura-del-documento)

[2. Estado del arte [15](#estado-del-arte)](#estado-del-arte)

[3. Simulación de las dinámicas del vehículo
[17](#simulación-de-las-dinámicas-del-vehículo)](#simulación-de-las-dinámicas-del-vehículo)

[3.1. Motor [17](#motor)](#motor)

[3.2. Transmisión [19](#transmisión)](#transmisión)

[3.3. Tren motriz [19](#tren-motriz)](#tren-motriz)

[3.4. Diferencial [21](#diferencial)](#diferencial)

[3.5. Suspensión [23](#suspensión)](#suspensión)

[3.5.1. Barras antivuelco [23](#barras-antivuelco)](#barras-antivuelco)

[3.6. Neumáticos [24](#neumáticos)](#neumáticos)

[3.7. Aerodinámica [27](#aerodinámica)](#aerodinámica)

[4. Modelos y escenarios
[28](#modelos-y-escenarios)](#modelos-y-escenarios)

[4.1. Creación de los vehículos en Unity
[28](#creación-de-los-vehículos-en-unity)](#creación-de-los-vehículos-en-unity)

[4.1.1. Elección de los modelos
[28](#elección-de-los-modelos)](#elección-de-los-modelos)

[4.1.2. Modelado 3D [31](#modelado-3d)](#modelado-3d)

[4.1.3. Texturizado de los modelos 3D
[31](#texturizado-de-los-modelos-3d)](#texturizado-de-los-modelos-3d)

[4.1.4. Creación del prefab de los vehículos en Unity
[32](#creación-del-prefab-de-los-vehículos-en-unity)](#creación-del-prefab-de-los-vehículos-en-unity)

[4.2. Control del vehículo
[33](#control-del-vehículo)](#control-del-vehículo)

[4.2.1. Acciones para controlar el vehículo
[34](#acciones-para-controlar-el-vehículo)](#acciones-para-controlar-el-vehículo)

[4.2.2. Creación del mapa de controles
[34](#creación-del-mapa-de-controles)](#creación-del-mapa-de-controles)

[4.2.3. Creación del script de control del vehículo
[35](#creación-del-script-de-control-del-vehículo)](#creación-del-script-de-control-del-vehículo)

[4.3. Creación de un circuito
[39](#creación-de-un-circuito)](#creación-de-un-circuito)

[4.3.1. Creación del modelo 3D del circuito
[39](#creación-del-modelo-3d-del-circuito)](#creación-del-modelo-3d-del-circuito)

[4.3.2. Texturizado del modelo 3D del circuito
[39](#texturizado-del-modelo-3d-del-circuito)](#texturizado-del-modelo-3d-del-circuito)

[5. Interfaz de usuario
[41](#interfaz-de-usuario)](#interfaz-de-usuario)

[5.1. Selector de vehículos
[41](#selector-de-vehículos)](#selector-de-vehículos)

[5.1.1. Prefab de los vehículos del selector.
[42](#prefab-de-los-vehículos-del-selector.)](#prefab-de-los-vehículos-del-selector.)

[5.1.2. Canvas del selector de vehículos
[43](#canvas-del-selector-de-vehículos)](#canvas-del-selector-de-vehículos)

[5.1.3. Audio Manager del selector de vehículos
[44](#audio-manager-del-selector-de-vehículos)](#audio-manager-del-selector-de-vehículos)

[5.2. Spawner de vehículos
[44](#spawner-de-vehículos)](#spawner-de-vehículos)

[5.3. Interfaz de conducción
[45](#interfaz-de-conducción)](#interfaz-de-conducción)

[1.1.1. Creación de los elementos visuales
[46](#creación-de-los-elementos-visuales)](#creación-de-los-elementos-visuales)

[1.1.2. Implementación de los elementos visuales en Unity
[46](#implementación-de-los-elementos-visuales-en-unity)](#implementación-de-los-elementos-visuales-en-unity)

[1.1.3. Canvas Manager [47](#canvas-manager)](#canvas-manager)

[5.4. Sistema de tiempos [49](#sistema-de-tiempos)](#sistema-de-tiempos)

[1.1.4. Prebaf de la zona de detección
[50](#prebaf-de-la-zona-de-detección)](#prebaf-de-la-zona-de-detección)

[1.1.5. Scripts del sistema de tiempo
[50](#scripts-del-sistema-de-tiempo)](#scripts-del-sistema-de-tiempo)

[5.5. Menú de pausa [55](#menú-de-pausa)](#menú-de-pausa)

[5.5.1. Pause Manager [56](#pause-manager)](#pause-manager)

[5.6. Game Manager [57](#game-manager)](#game-manager)

[6. Conclusiones [58](#conclusiones)](#conclusiones)

[6.1. Introducción [58](#introducción-1)](#introducción-1)

[6.2. Funcionalidad Implementada
[58](#funcionalidad-implementada)](#funcionalidad-implementada)

[6.3. Mejoras a futuro y problemas actuales
[64](#mejoras-a-futuro-y-problemas-actuales)](#mejoras-a-futuro-y-problemas-actuales)

[7. Bibliografía [65](#_Toc171504734)](#_Toc171504734)

#  Tabla de ilustraciones

[Ilustración 1 Captura de pantalla del Trello del proyecto
[14](#_Toc171504760)](#_Toc171504760)

[Ilustración 2 Ajustes de vehículo y diferentes sistemas simulados en
Gran Turismo 7 [16](#_Toc171504761)](#_Toc171504761)

[Ilustración 3 Comparativa ente Gran Turismo 2 y 7
[17](#_Toc171504762)](#_Toc171504762)

[Ilustración 4 Peugeot 205 GTI, imagen de Vauxford — Trabajo propio, CC
BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=71711116
[29](#_Toc169094972)](#_Toc169094972)

[Ilustración 5 Peugeot 205 T16 Rally, Imagen Thesupermat - Trabajo
propio, CC BY-SA 3.0,
https://commons.wikimedia.org/w/index.php?curid=13443514
[30](#_Toc169094973)](#_Toc169094973)

[Ilustración 6 Mercedes 190E EVO II, imagen de Matti Blume - Trabajo
propio, CC BY-SA 4.0,
https://commons.wikimedia.org/w/index.php?curid=67806616
[30](#_Toc171504765)](#_Toc171504765)

[Ilustración 7 Mercedes 190E EVO II DTM, imagen de dominio publico,
https://commons.wikimedia.org/w/index.php?curid=242256
[31](#_Toc171504766)](#_Toc171504766)

[Ilustración 8 Ferrari F2004, imagen de Rick Dikeman - Trabajo propio,
CC BY-SA 3.0, https://commons.wikimedia.org/w/index.php?curid=24471
[31](#_Toc171504767)](#_Toc171504767)

[Ilustración 9 Turn Arround de Peugeot 205 GTI. Xeon Zeuz.
peugeot-205-gti-2\[Picture\]. the-blueprints.com.
https://www.the-blueprints.com/blueprints/cars/peugeot/744/view/peugeot_205_gti/
[32](#_Toc171504768)](#_Toc171504768)

[Ilustración 10 Demostración de un modelo 3D de un vehículo previa
aplicación del modificador Mirror de Blender
[32](#_Toc171504769)](#_Toc171504769)

[Ilustración 11 Texturas dibujadas en Photoshop sobre el mapa de Uvs del
modelo [33](#_Toc171504770)](#_Toc171504770)

[Ilustración 12 Prefab completo de un vehículo controlable
[34](#_Toc171504771)](#_Toc171504771)

[Ilustración 13 Esquema del mapa de controles creado. Imágenes
originales de Tokyoship, Wikimedia Commons, CC BY 3.0,
https://commons.wikimedia.org/w/index.php?curid=24802891
[36](#_Toc171504772)](#_Toc171504772)

[Ilustración 14 Figura 2-92 de (Jacobson, 2016)
[37](#_Toc171504773)](#_Toc171504773)

[Ilustración 15 Canvas del menú del selector de vehículos
[44](#_Toc171504774)](#_Toc171504774)

[Ilustración 16 Canvas de la interfaz de conducción
[46](#_Toc171504775)](#_Toc171504775)

[Ilustración 17 tacómetro creado en Photoshop
[47](#_Toc171504776)](#_Toc171504776)

[Ilustración 18 Barras de los inputs de acelerador, freno y dirección
[47](#_Toc171504777)](#_Toc171504777)

[Ilustración 19 tacómetro implementado en Unity
[48](#_Toc171504778)](#_Toc171504778)

[Ilustración 20 Interfaz de tiempos de la interfaz de conducción
[50](#_Toc171504779)](#_Toc171504779)

[Ilustración 21 Prefab de la zona de detección de tiempos
[51](#_Toc171504780)](#_Toc171504780)

[Ilustración 22 Canvas del menú de pausa
[57](#_Toc171504781)](#_Toc171504781)

[Ilustración 23 Comparativa entre Auto-Modellista y este proyecto
[59](#_Toc171504782)](#_Toc171504782)

[Ilustración 24 Figura 1 del Artículo de Seibum Choi
[61](#_Toc171504783)](#_Toc171504783)

[Ilustración 25 Curva de agarre longitudinal de los neumáticos base
[62](#_Toc171504784)](#_Toc171504784)

[Ilustración 26 Curva de agarre de demostración en la documentación del
WheelCollider [62](#_Toc171504785)](#_Toc171504785)

[Ilustración 27 Medidas tomadas para calcular el área frontal de cada
vehículo [63](#_Toc171504786)](#_Toc171504786)

[Ilustración 28 Zonas de carga aerodinámica en el Mercedes 190E EVO II
DTM en Assetto Corsa [63](#_Toc171504787)](#_Toc171504787)

[Ilustración 29 Demostración de las interfaces creadas
[64](#_Toc171504788)](#_Toc171504788)

[Ilustración 30 Submenú de ajuste de Control de tracción de la interfaz
de Gran Turismo 7 [65](#_Toc171504789)](#_Toc171504789)

# Tabla de código 

[Código 1 Método CalcTorque [18](#_Toc171504822)](#_Toc171504822)

[Código 2 Bucle For del método GetRange
[18](#_Toc171504823)](#_Toc171504823)

[Código 3 Método SimulatePowerTrain
[20](#_Toc171504824)](#_Toc171504824)

[Código 4 Método GetPwWheelRPM [20](#_Toc171504825)](#_Toc171504825)

[Código 5 Método GetPwWheelsRotSpeed
[21](#_Toc171504826)](#_Toc171504826)

[Código 6 Calculo de la resistencia del neumático izquierdo en el método
CalcRes. [21](#_Toc171504827)](#_Toc171504827)

[Código 7 Calculo del torque por neumático en el caso del diferencial
abierto [22](#_Toc171504828)](#_Toc171504828)

[Código 8 Calculo del torque por neumático en el caso del diferencial
autoblocante [22](#_Toc171504829)](#_Toc171504829)

[Código 9 Calculo del torque por neumático en el caso del diferencial
soldado [22](#_Toc171504830)](#_Toc171504830)

[Código 10 Calculo de la distancia de la suspensión
[24](#_Toc171504831)](#_Toc171504831)

[Código 11 Calculo de la fuerza realizada por la barra antivuelco y su
posterior aplicación en el chasis [24](#_Toc171504832)](#_Toc171504832)

[Código 12 Funcionamiento del cambio de curva de agarre según el
terreno. [25](#_Toc171504833)](#_Toc171504833)

[Código 13 Bucle for del ajuste visual de los modelos 3D de los
neumáticos [26](#_Toc171504834)](#_Toc171504834)

[Código 14 Funcionamiento de la activación de las marcas de derrape de
los neumáticos [27](#_Toc171504835)](#_Toc171504835)

[Código 15 Calculo de la resistencia y carga aerodinámica del vehículo
[27](#_Toc171504836)](#_Toc171504836)

[Código 17 Método setDiffWheels [37](#_Toc171504837)](#_Toc171504837)

[Código 18 Método setSetup [37](#_Toc171504838)](#_Toc171504838)

[Código 19 Funcionamiento del instanciador de vehículos en el selector
[42](#_Toc171504839)](#_Toc171504839)

[Código 20 Carga en memoria de los prefabs del selector de vehículos
[42](#_Toc171504840)](#_Toc171504840)

[Código 21 Método ChangedData [44](#_Toc171504841)](#_Toc171504841)

[Código 22 Método playSound [44](#_Toc171504842)](#_Toc171504842)

[Código 23 Inicialización del script Player Car Spawner
[45](#_Toc171504843)](#_Toc171504843)

[Código 24 Funcionamiento de la visualización del input de dirección
[48](#_Toc171504844)](#_Toc171504844)

[Código 25 Funcionamiento de la visualización de la marcha seleccionada
en la caja de cambios [49](#_Toc171504845)](#_Toc171504845)

[Código 26 Método TimerComponents [51](#_Toc171504846)](#_Toc171504846)

[Código 27 Método nextSec [52](#_Toc171504847)](#_Toc171504847)

[Código 28 Método NextLap [52](#_Toc171504848)](#_Toc171504848)

[Código 29 Método LastLapUpdater [53](#_Toc171504849)](#_Toc171504849)

[Código 30 Método SectorUpdater [54](#_Toc171504850)](#_Toc171504850)

[Código 31 Método ColorSec [54](#_Toc171504851)](#_Toc171504851)

[Código 32 Método OnTriggerEnter del script SecCheck
[55](#_Toc171504852)](#_Toc171504852)

[Código 33 Método Update del script PauseManager
[57](#_Toc171504853)](#_Toc171504853)

# Tabla de Graficas

[Gráfica 1 Curva de torque por revoluciones por minuto habitual de un
motor de combustión interna [16](#_Toc170425312)](#_Toc170425312)

[Gráfica 2 Agarre longitudinal del neumático base creado
[24](#_Toc170425313)](#_Toc170425313)

[Gráfica 3 Curva de torque del Mercedes 190E EVO II DTM
[58](#_Toc170425314)](#_Toc170425314)

[Gráfica 4 Velocidad por marcha del Mercedes 190E EVO II DTM
[58](#_Toc170425315)](#_Toc170425315)

# Resumen

“Karu Racing: simulador de coches Simcade con físicas y modelos de
coches reales” es una propuesta de juego de conducción simcade, es
decir, dentro de los juegos de simulación de conducción los más arcades
Ejemplos populares de simcades son Gran Turismo, Dirt y Forza
Horizon/MotorSport. Cuyo público objetivo son los jugadores de juegos de
conducción que buscan una experiencia de sensación realista, pero a la
vez accesible y más relajada que la simulación pura.

Para ello se ha implementado un sistema de físicas creíbles que
transmiten esta sensación de realismo, pero a la vez accesible al
jugador promedio, jugador que no necesita un volante con sistema háptico
ni pedales. Todos los modelos 3D creados, tanto de los vehículos
seleccionados, como del circuito elegido y la interfaz implementada, se
han realizado en base a toda la información necesaria para que el
jugador pueda saber que está ocurriendo con el vehículo.

# Abstract

‘Karu Racing: Simcade car simulator with real car physics and models’ is
a simcade driving game approach, i.e. within driving simulation games
the most arcade-like driving games. Popular examples of simcades are
Gran Turismo, Dirt and Forza Horizon/MotorSport. The target audience are
driving game players who are looking for a realistic feeling experience,
but at the same time accessible and more relaxed than pure simulation.

To this end, a believable physics system has been implemented that
conveys this realistic feel, but is still accessible to the average
gamer, who does not need a haptic steering wheel or pedals. In addition,
all 3D models of both the selected vehicles and the created track have
been created. The implemented interface has also been created, based on
all the information necessary for the player to know what is happening
with the vehicle.

# Introducción

“Karu Racing” es un proyecto que intenta llenar el vacío que con los
años se ha ido generando entre los juegos de simulación y los juegos
simcades debido a diferentes motivos: el paso de Need for Speed a un
modelo de físicas mucho más arcade, el auge de los juegos de simulación
pura y los esports…y al declive de sagas de simcades como los juegos
oficiales de Formula 1, Dirt o Forza MotorSport.

## Descripción del problema

La principal problemática de este trabajo es discernir que módulos del
funcionamiento real de un vehículo se han de simular y que grado de
simulación se ha de alcanzar por cada uno. Ya que si bien se busca una
sensación real también un modelo que sea general, accesible y
disfrutable.

## Motivación

La motivación principal de este trabajo es la pasión personal por el
mundo del motor en general y las competiciones de motor como el WEC y la
Formula 1.

Otro motivo es el abandono generalizado de los juegos de conducción
simcade o falta de buenas físicas de conducción en juegos de conducción
triple A, como es el caso del reciente F1 2024, donde el juego de salida
tiene un sistema de físicas roto.

## Objetivos

### Objetivo principal

> El objetivo principal de este trabajo fin de grado es completar un
> modelo de físicas de conducción que simule de manera aproximada las
> dinámicas de un vehículo dentro de un motor de videojuegos, para ello,
> tras la realización del estado del arte, se presenta la siguiente
> lista de dinámicas a simular:

- **Motor:** Curva de torque y cargas.

- **Transmisión:** Diferentes ratios de los engranajes el funcionamiento
  > de los diferentes tipos de diferenciales y tipos de propulsión.

- **Suspensión:** Diferencia de durezas en los muelles y amortiguadores.

- **Neumáticos:** Interacción entre los neumáticos y el terreno.

- **Aerodinámica:** Como se genera la carga aerodinámica y como esta
  > afecta a la dinámica del vehículo.

### Objetivos secundarios

#### Interfaz 

> Creación de una interfaz que transmita al jugador información relativa
> a cuestiones como velocidad, marcha seleccionada, revoluciones por
> minuto del motor o estado de los neumáticos.
>
> No solo la creación de esta, si no, para la consecución de este
> objetivo es necesario que la interfaz tenga una estética coherente y
> cohesionada.

#### Estilo visual 

> Elección de un estilo visual y estética que aporten identidad al
> posible juego derivado de la consecución del objetivo principal de
> este trabajo fin de grado.

## Metodología

Durante el desarrollo de este proyecto se ha seguido una metodología en
cascada donde, una vez se discernió los módulos a simular y los
vehículos a modelar, se realizó una lista de tareas que se fue
cumpliendo en orden. Para mantener el orden de la lista de tareas y
organizarlas por tipo y estado de éstas se ha usado Trello, y se han
utilizado las cuatro columnas relacionadas a continuación para
diferenciar el estado de las tareas:

- **Cosas por hacer:** En esta columna se colocan las tareas que se han
  planeado, pero que todavía no se ha iniciado su desarrollo

- **Haciendo:** En esta columna se colocan las tareas cuyo desarrollo ha
  comenzado.

- **Hechas:** En esta columna se colocan las tareas cuyo desarrollo se
  ha completado de manera satisfactoria.

- **Revisar:** En esta columna se colocan las tareas cuyo desarrollo se
  ha completado, pero sobre las que se quiere realizar una revisión de
  su implementación y/o funcionamiento.

Aparte cada tarea tiene una etiqueta que identifica el tipo de tarea que
es, etiquetas que se categorizan en cinco:

- **Modelo de físicas:** Todas las tareas que se refieren a la
  implementación de las dinámicas de vehículos.

- **Modelado:** Todas las tareas que se refieren al modelado de
  vehículos y circuitos.

- **Texturizado:** Todas las tareas que se refieren al texturizado de
  vehículos y circuitos.

- **Interfaz:** Todas las tareas que se refieren a la implementación de
  las diferentes interfaces.

- **Memoria:** Todas las tareas que se refieren a la memoria técnica del
  proyecto.

<img src="media/image2.png" style="width:5.90556in;height:3.65in"
alt="Una captura de pantalla de un videojuego Descripción generada automáticamente con confianza media" />

<span id="_Toc171504760" class="anchor"></span>Ilustración 1 Captura de
pantalla del Trello del proyecto

## Estructura del documento

El documento se ha estructurado en 5 capítulos principales:

- **Estado del arte:** En este capítulo se realiza un estudio de otros
  juegos de conducción, más concretamente de la saga Gran Turismo.

- **Simulación de las dinámicas del vehículo:** En este capítulo se
  explica el desarrollo de los módulos creados para simular el
  comportamiento de un vehículo en Unity.

- **Modelos y escenarios:** En este capítulo se explica la selección y
  creación de tanto de los diferentes modelos de vehículos, como de un
  circuito y los assets necesarios para el juego.

- **Interfaz de usuario:** En este capítulo se explica el desarrollo de
  las diferentes interfaces de usuario creadas para el juego, tanto a
  nivel artístico como a nivel técnico.

- **Conclusiones:** En este capítulo se explican los resultados
  obtenidos, los elementos planeados pero que no se han logrado integrar
  y las posibles mejoras a futuro del proyecto.

Se ha escogido esta estructura debido a que el desarrollo del proyecto
se puede dividir en estos capítulos muy diferenciados, además se asemeja
bastante a las diferentes etiquetas explicadas en el apartado de
metodología.

# Estado del arte 

Uno de los mayores exponentes de los juegos de conducción es la saga
Gran Turismo, desarrollada por Polyphony Digital, que comenzó en 1997
con el lanzamiento de Gran Turismo para la Sony PlayStation, continuando
con distintos lanzamientos de la serie desde esa fecha hasta la puesta
en el mercado en 2022 de la última entrega, Gran Turismo 7 para la Sony
PlayStation 4 y 5. Originalmente aclamado por su enfoque más realistas
que otros juegos de conducción de la época, pasa a integrar poco a poco
más y más elementos a la simulación de dinámicas de vehículos con cada
entrega. Comenzando con una “simple” simulación de tipos de tracción,
distribuciones de peso y desgaste de neumáticos, hasta la actualidad,
donde existe una simulación muy completa en la que se tiene en cuenta el
entorno, es decir, temperatura ambiente y del asfalto, el flujo del
aire, condiciones meteorológica dinámicas; y en cuanto a los vehículos,
se simula la deformación y temperatura de los neumáticos y su
interacción con diferentes tipos de terrenos, diferentes tipos de
suspensiones y su configuración, carga aerodinámica avanzada, además de
otros elementos como consumos de combustible con diferentes mapas motor.

<img src="media/image3.jpeg" style="width:5.90556in;height:2.81181in"
alt="Interfaz de usuario gráfica Descripción generada automáticamente" />

<span id="_Toc171504761" class="anchor"></span>Ilustración 2 Ajustes de
vehículo y diferentes sistemas simulados en Gran Turismo 7

Si bien todo apunta a que Gran Turismo es un juego de simulación pura,
el consenso general lo cataloga de simcade, ya que aunque tiene un
modelo de físicas muy avanzado, sigue siendo un videojuego diseñado para
ser jugado en mando y es accesible para jugadores a todos los niveles,
garantizando así estar siempre en el top de ventas de videojuegos de
cada respectiva consola en la que fue lanzado: Gran Turismo 1 y 2 están
el top 1 y 3 de ventas en PlayStation , Gran Turismo 3 y 4 están en el
top 2 y 3 de ventas en PlayStation 2, Gran Turismo 5 y 6 están top 2 y 9
de ventas en PlayStation 3 y Gran Turismo Sport está top 5 de ventas en
PlayStation 4.

<img src="media/image4.png" style="width:5.90556in;height:1.88889in"
alt="Imagen de la pantalla de un video juego de una carretera Descripción generada automáticamente con confianza media" />

<span id="_Toc171504762" class="anchor"></span>Ilustración 3 Comparativa
ente Gran Turismo 2 y 7

Por estos motivos, en lo personal, se cataloga Gran Turismo como el
mayor videojuego del género simcade. Es una de las inspiraciones
principales de este proyecto, donde se busca un modelo de físicas de
vehículos que se asemeje a la realidad pero que a la vez sea cercano y
asequible para cualquier jugador con un mando estándar.

Para definir que dinámicas se han de implementar para que el modelo de
físicas se sienta realista, además de inspirarse en el modelo de físicas
del propio Gran Turismo, se ha realizado un estudio de las dinámicas de
vehículos. Para ello, entre la bibliografía utilizada está el libro
*Vehicle Dynamic* por Bengt Jacobson (Jacobson, 2016), que en sus 390
páginas detalla el funcionamiento de todas las dinámicas que intervienen
en un vehículo y su funcionamiento, de la misma forma que el articulo
*Development, Validation and RT Performance Assessment of a Platform for
Driver-in-the-Loop Simulation of Vehicle Dynamics* por Domenico Mundo,
Roberta Gencarelli, Luca Dramisino y Carlos Gare. (Mundo, Gencarelli,
Dramisino, & Garre, 2019).

Gracias a este libro se ha logrado descifrar gran parte de la
implementación de cada módulo descrito en los objetivos de este
documento.

# Simulación de las dinámicas del vehículo

Tras haber realizado el estado del arte se ha procedido a realizar la
implementación de los módulos presentados en el apartado de objetivos en
Unity.

## Motor

Para la simulación de un motor de combustión interna se ha creado un
script llamado *Engine Base* que posee un array bidimensional de torque
según revoluciones por minuto, inercia del motor y las propias
revoluciones por minuto del motor, también, el script implementa dos
métodos, *GetRange* y *CalcTorque*.

<span id="_Toc170425312" class="anchor"></span>Gráfica 1 Curva de torque
por revoluciones por minuto habitual de un motor de combustión interna

A continuación, se explican los dos métodos:

- **CalcTorque:** Dadas 2 posiciones del array de torque-revoluciones
  por minuto y las revoluciones por minuto actuales del motor, interpola
  linealmente el valor de torque devuelto según las revoluciones por
  minuto actuales del motor.

<span id="_Toc171504822" class="anchor"></span>Código 1 Método
CalcTorque

- **GetRange:** Este método usa un *for* que recorre el array de
  torque-revoluciones. Mientras lo recorre se revisa si las revoluciones
  por minuto actuales están dentro del rango del array bidimensional, si
  es así y la posición del array revisada es la más cercana por arriba a
  las revoluciones por minuto actuales del motor, el método devuelve el
  valor que devuelva el método *CalcTorque.* Si el valor de las
  revoluciones por minuto actuales del motor esta fuera del rango del
  array de torque-revoluciones, si éste es menor al de la primera
  posición del array se devuelve el torque de la primera posición del
  array y si el valor de revoluciones por minuto es mayor que el de la
  última posición del array se devuelve cero, para simular como las
  centralitas de los motores cortan la inyección de combustible una vez
  las revoluciones por minuto alcanzan el límite de revoluciones por
  minuto máximas.

<span id="_Toc171504823" class="anchor"></span>Código 2 Bucle For del
método GetRange

Además, este script hereda de *ScriptableObject* para poder crear
diferentes motores directamente en el editor del propio Unity.

## Transmisión 

Para simular la transmisión de un vehículo se ha creado un script
llamado *Gearbox Base* que contiene un array con las ratios de cada
marcha y un *int* que representa la marcha en la que se encuentra la
propia transmisión, además tiene un método *GetGearing* que devuelve la
multiplicación del ratio de la marcha actual y el ratio del diferencial.

## Tren motriz

Una vez simulados tanto el motor como la transmisión se ha creado el
script de *PowerTrain Base* que une el motor y transmisión, simulando
así el tren motriz del vehículo. Este script toma un *Engine base* y un
*Gearbox base* y usa la información de ambos scripts para los siguientes
métodos:

- **SimulatePowerTrain:** Este método ajusta las revoluciones por minuto
  del motor dependiendo de la marcha en la que se encuentra la
  transmisión, si esta está en punto muerto, el motor gira libremente
  entre el valor mínimo y el valor máximo de revoluciones por minuto del
  array torque-revoluciones por minuto según el valor del acelerador. En
  cambio, si hay engranada una marcha el motor gira a la velocidad
  determinada por el método *GetPwWheelsRPM*. Asimismo, el método
  *SimulatePowerTrain* revisa que la velocidad del motor no supere el
  rango máximo dado por el *Engine Base*, si este es superado se limita
  la velocidad de giro a este máximo más 200 más menos 50 revoluciones
  por minuto.

<span id="_Toc171504824" class="anchor"></span>Código 3 Método
SimulatePowerTrain

- **GetPwWheelsRPM:** Este método devuelve la velocidad media de
  revoluciones por minuto a las que giran las ruedas que impulsan el
  vehículo, aplicando también el cambio de velocidad producido en la
  caja de cambios.

<span id="_Toc171504825" class="anchor"></span>Código 4 Método
GetPwWheelRPM

- **GetPwWheelsRotSpeed:** Este método realiza el mismo trabajo que
  *GetPwWheelsRPM* pero devuelve la velocidad en grados por segundo.

<span id="_Toc171504826" class="anchor"></span>Código 5 Método
GetPwWheelsRotSpeed

## Diferencial

Para la implementación del diferencial se ha creado el script
*Differential Base* que toma como datos los *WheelCollider* de las
ruedas izquierda y derecha, siendo estas asignadas a través del editor,
y del tipo de diferencial, éste junto con el torque dado por el tren
motriz son usados en los siguientes métodos:

- **CalcRes:** Este método usa el valor devuelto por el método
  *fowardSlip* de los WheelColliders de las ruedas para calcular la
  resistencia de cada rueda, siendo el cálculo uno menos el valor
  devuelto por *forwardSlip* ya que *forwardSlip* devuelve valores entre
  -1 y 1, siendo los valores negativos exclusivos al valor de slip en
  frenada, por lo que se pueden obviar en este cálculo.

<span id="_Toc171504827" class="anchor"></span>Código 6 Calculo de la
resistencia del neumático izquierdo en el método CalcRes.

- **DistributeTorque:** Este método primero calcula el valor de
  resistencia de cada neumático con *CalcRes* y junto con el valor del
  torque del tren motriz y el tipo de diferencial calcula el porcentaje
  de torque que se transfiere a cada rueda de la siguiente manera:
  torque del tren motriz multiplicado por la división entre la
  resistencia del neumático entre la resistencia total de ambas ruedas,
  dependiendo del tipo de diferencial este torque calculado va a una
  rueda o la contraria. Existen tres casos:

  - **Diferencial Abierto:** En un diferencial abierto el torque del
    tren motriz sigue el camino de menor resistencia, por lo que tal y
    como están hechos los cálculos, el torque calculado para cada rueda
    se invierte, es decir, el torque calculado para la rueda izquierda
    se pasa a la rueda derecha y viceversa.

<span id="_Toc171504828" class="anchor"></span>Código 7 Calculo del
torque por neumático en el caso del diferencial abierto

- **Diferencial Autoblocante:** En un diferencial autoblocante el
  diferencial se va cerrando según aumenta la diferencia de velocidad
  entre ambas ruedas. En este caso el torque de cada rueda es el
  calculado para esa rueda.

<span id="_Toc171504829" class="anchor"></span>Código 8 Calculo del
torque por neumático en el caso del diferencial autoblocante

- **Diferencia Soldado:** En un diferencial soldado la división de
  torque siempre es 50/50 para cada rueda, por lo que el torque a cada
  rueda es el torque del tren motriz multiplicado por 0.5.

<span id="_Toc171504830" class="anchor"></span>Código 9 Calculo del
torque por neumático en el caso del diferencial soldado

Una vez se tienen tren motriz y diferencial se puede pasar a simular el
resto de las partes del vehículo.

## Suspensión 

Para simular la suspensión del vehículo se ha decidido usar el
*WheelCollider* que proporciona el propio motor de Unity. Esto es debido
a que, si bien no es el módulo más estable, da un resultado lo
suficientemente realista, y su uso es razonablemente sencillo en
comparación con implementar manualmente toda la funcionalidad de la
suspensión de un vehículo.

El *WheelCollider* ofrece todo lo necesario para simular la suspensión
de un vehículo: recorrido de la suspensión, dureza del muelle, dureza
del amortiguador, peso del neumático y efecto de muelle del neumático.

### Barras antivuelco

Las barras antivuelco comparten la fuerza de compresión de un lado de la
suspensión con el lado contrario, reduciendo así el ladeo del chasis del
vehículo. La simulación de este módulo de la suspensión viene dada por
la implementación del usuario Edy en los foros de Unity (Edy, 2017),
aunque ésta se ha modificado ligeramente. A continuación, se explica el
script *AntiRollBar.*

Las variables principales del script son:

- **WheelL/R:** Son dos variables de tipo *WheelCollider* que
  representan las dos suspensiones que une la barra antivuelco.

- **antiRoll:** Es una variable de tipo *float* que representa el valor
  de fuerza de la barra antivuelco.

Durante la actualización de este script en el método *FixedUpdate,* se
calcula la distancia de la suspensión de cada lado, es decir, la
posición de la suspensión entre el punto de máxima compresión y máxima
extensión, en este caso representados por un valor entre cero, máxima
compresión, y uno, máxima extensión.

<span id="_Toc171504831" class="anchor"></span>Código 10 Calculo de la
distancia de la suspensión

Una vez realizado este cálculo se calcula la fuerza que realiza la barra
antivuelco, multiplicando el *antiRoll* por la resta del valor de ambas
posiciones y ésta se aplica al *RigidBody* del chasis del vehículo en la
posición de cada *WheelCollider.*

<span id="_Toc171504832" class="anchor"></span>Código 11 Calculo de la
fuerza realizada por la barra antivuelco y su posterior aplicación en el
chasis

## Neumáticos

Para simular los neumáticos, se ha usado el *WheelCollider* del propio
Unity junto con varios Scripts para tener neumáticos preconfigurado y
poder cambiar el agarre de cada neumático según el tipo de terreno. A
continuación, se explican los scripts:

- **TerrainManager:** Decide que curva de agarre usa el neumático según
  el neumático que monte el vehículo en el setup del mismo, y según el
  tag del objeto con el que colisiona la rueda, Esto se realiza a través
  de un switch en el método *Update* donde cada caso es un tipo de
  terreno.

<span id="_Toc171504833" class="anchor"></span>Código 12 Funcionamiento
del cambio de curva de agarre según el terreno.

- **Tyre Base:** Este script es un *scriptable object* que permite crear
  diferentes tipos de neumáticos tomando como valores los puntos
  *Extremum* y *Asymptote* de las curvas de agarre de los neumáticos.
  Como, dependiendo de la superficie, la curva de agarre adopta una
  forma diferente, se han creado valores para 2 tipos de curva:
  *normalCurve* para terrenos de asfalto y *dirtCurve* para terrenos
  similares a grava y arena, ambas curvas tienen dos versiones
  representando el agarre longitudinal y lateral del neumático.

- 

<span id="_Toc170425313" class="anchor"></span>Gráfica 2 Agarre
longitudinal del neumático base creado

> Para simular cambios en las condiciones meteorológicas cada curva
> tiene varios valores de *Stiffness* dependiendo de si la superficie
> esta seca o mojada. El *Stiffnes* de una curva de agarre es un
> multiplicador de agarre para la misma, por lo que en situaciones donde
> el comportamiento del neumático es muy similar pero el agarre es
> menor, es más eficiente cambiar el valor de *Stiffnes* de la curva que
> crear una curva completamente nueva.

- **Wheel Controller:** Este script se encarga de todo lo referente a la
  visualización de las ruedas del vehículo ya que el *WheelCollider*
  solo trabaja a nivel de físicas. Este script toma los *WheelCollider*
  del vehículo y obtiene su posición y rotación con el método
  *GetWorldPose* y aplica la posición al modelo 3D de la rueda
  correspondiente, la rotación depende de si es del lado izquierdo o
  derecho. Al modelo 3D se le aplica una rotación extra de + o - 90
  grados en el eje Z para que la rotación de este corresponda
  visualmente a la del *WheelCollider.*

<span id="_Toc171504834" class="anchor"></span>Código 13 Bucle for del
ajuste visual de los modelos 3D de los neumáticos

> Igualmente, el script se encarga de las marcas de derrape del
> neumático. Esto se ha conseguido creando un array de *Line Rendeders*
> que usa un material del mismo color que los neumáticos, cuya posición
> se actualiza junto con los modelos 3D de las ruedas, y se activa o
> desactiva si el forward o lateral slip que devuelve el *WheelCollider*
> es mayor o menor que un valor arbitrario ajustable en el editor de
> Unity.

<span id="_Toc171504835" class="anchor"></span>Código 14 Funcionamiento
de la activación de las marcas de derrape de los neumáticos

## Aerodinámica

Para simular la aerodinámica de los vehículos se ha creado el script
*Aero Sim Base,* que aplica la fórmula de la resistencia aerodinámica:
$F\_{d} = \frac{1}{2}\rho\\v^{2}\\c\_{d}\\A$, donde ***ρ*** es la
densidad del aire que es 1,225 **Kg/m^3**, **v**<sup>**2**</sup> que en
este caso es la velocidad del vehículo al cuadrado que se obtiene desde
el *RigidBody* del vehículo con el método *velocity.magnitude,*
**c**<sub>**d**</sub> es el coeficiente de drag, éste es especifico de
cada vehículo y se suele obtener rápidamente con una búsqueda online, y
***A*** que es el área frontal del vehículo en **m^2** que de nuevo es
especifica de cada vehículo y en este caso se ha calculado usando la
vista frontal ortográfica de cada modelo 3D y la herramienta de medición
de Blender.

Una vez se tienen todos los valores de la formula, en el script, se
calcula *F*<sub>*d*</sub> en el *FixedUpdate* del script y se cambia el
valor de drag del *RigidBody* del vehículo al de *F*<sub>*d*</sub>
dividido entre mil ya que la relación de magnitudes entre el drag en
Unity es diferente al dado por la formula y este se ha ajustado basado
en la velocidad máxima de los vehículos en la vida real.

El script también puede simular a nivel muy básico carga aerodinámica,
donde se usa un coeficiente aerodinámico arbitrario y la velocidad
obtenida con el método *velocity.sqrMagnitude* se aplica una fuerza al
*RigidBody* del vehículo en dirección -Y del propio *RigidBody*.

<span id="_Toc171504836" class="anchor"></span>Código 15 Calculo de la
resistencia y carga aerodinámica del vehículo

# Modelos y escenarios

En este apartado se va a explicar el proceso de creación de los modelos
3D de los vehículos y escenarios, y cómo se han creado los prefabs de
los vehículos controlables por el jugador en Unity.

## Creación de los vehículos en Unity

Una vez se ha conseguido simular todas las dinámicas propuestas se ha de
crear el vehículo en Unity. A continuación, se explica paso a paso como
se han creado los vehículos.

### Elección de los modelos

Para la elección de los vehículos se ha tenido en cuenta principalmente
dos componentes: preferencia personal y diversidad entre ellos, es
decir, que cada vehículo sea diferenciable del resto y demuestre los
diferentes tipos de posiciones de motores, tipos de tracción y
diferenciales.

Los modelos elegidos son los siguientes:

- **Peugeot 205 GTI:** Ejemplo de un coche ligero, ágil y de potencia
  modesta, de tracción delantera y motor frontal.

  - **Información técnica del vehículo:** (Horsepower and Torque curve
    for 1990 Peugeot 205 GTI 1.9, s.f.)

  - **Turn Arround del vehículo:** (Peugeot 205 GTi, s.f.)

> <img src="media/image5.jpeg" style="width:3.12292in;height:1.86318in"
> alt="Un coche antiguo estacionado en la calle Descripción generada automáticamente" />

<span id="_Toc169094972" class="anchor"></span>Ilustración 4 Peugeot 205
GTI, imagen de Vauxford — Trabajo propio, CC BY-SA 4.0,
<https://commons.wikimedia.org/w/index.php?curid=71711116>

- **Peugeot 205 T16 GROUP B:** Una versión extrema del 205 base, con
  tracción 4x4, motor central y mucha más potencia.

  - **Información técnica del vehículo:** (Horsepower and Torque curve
    for 1985 Peugeot 205 Turbo 16 Evolution 2, s.f.)

  - **Turn Arround del vehículo:** (Peugeot 205 Turbo 16, s.f.)

<img src="media/image6.jpeg" style="width:3.12205in;height:1.6447in" />

<span id="_Toc169094973" class="anchor"></span>Ilustración 5 Peugeot 205
T16 Rally, Imagen Thesupermat - Trabajo propio, CC BY-SA 3.0,
<https://commons.wikimedia.org/w/index.php?curid=13443514>

- **Mercedes 190E Evo II:** Versión especial de homologación del 190E
  base, de motor frontal y tracción trasera. Aunque relativamente
  potente es bastante pesado.

  - **Información técnica del vehículo:** (Horsepower and Torque curve
    for 1990 Mercedes-Benz 190 E 2.5-16 Evolution II, s.f.)

  - **Turn Arround del vehículo:** (Mercedes-Benz 190E Evolution II
    w201, s.f.)

<img src="media/image7.jpeg" style="width:3.12205in;height:2.15512in" />

<span id="_Toc171504765" class="anchor"></span>Ilustración 6 Mercedes
190E EVO II, imagen de Matti Blume - Trabajo propio, CC BY-SA 4.0,
<https://commons.wikimedia.org/w/index.php?curid=67806616>

- **Mercedes 190E Evo II DTM:** Versión de competición del 190E EVO II,
  más potente y ligero que la versión de calle del 190E EVO II, además
  de tener una caja de cambios distinta.

  - **Información técnica del vehículo:** Se ha usado la herramienta de
    *Content Manager* para acceder a los archivos de configuración del
    vehículo en Asseto Corsa y se han conseguido dichos datos.

  - **Turn Arround del vehículo:** (Mercedes-Benz 190E Evolution II
    w201, s.f.)

> <img src="media/image8.jpeg" style="width:3.12205in;height:1.61766in"
> alt="Imagen que contiene edificio, coche, estacionado, camioneta Descripción generada automáticamente" />

<span id="_Toc171504766" class="anchor"></span>Ilustración 7 Mercedes
190E EVO II DTM, imagen de dominio publico,
<https://commons.wikimedia.org/w/index.php?curid=242256>

- **Formula 1 2004/5:** Uno de los vehículos más extremos, motor central
  y tracción trasera, vehículo muy ligero y potente que genera una gran
  cantidad de carga aerodinámica. Este vehículo se ha modelado en base
  al Ferrari F2004, pero los datos de motor y transmisión son del
  Renault R25.

  - **Información técnica del vehículo:** Se ha usado la herramienta de
    *Content Manager* para acceder a los archivos de configuración del
    vehículo en Asseto Corsa y se han conseguido dichos datos.

  - **Área frontal:** ésta se ha calculado con el modelo 3D realizado

  <!-- -->

  - **Coeficiente aerodinámico/carga aerodinámica: t**ras varias
    búsquedas, se encontró que el coeficiente aerodinámico por norma
    general de un Formula 1 se encuentra entre 0.7 y 1.

  - **Turn Arround del vehículo:** (Ferrari F1 Formula 1 F2004, s.f.)

> <img src="media/image9.jpeg" style="width:3.12205in;height:1.34244in" />

<span id="_Toc171504767" class="anchor"></span>Ilustración 8 Ferrari
F2004, imagen de Rick Dikeman - Trabajo propio, CC BY-SA 3.0,
<https://commons.wikimedia.org/w/index.php?curid=24471>

### Modelado 3D

Para la creación de los modelos 3D se han buscado turn arounds de todos
los modelos seleccionados, intentando siempre crear con medidas de
referencia.

<img src="media/image10.jpeg"
style="width:3.18594in;height:2.18403in" />

<span id="_Toc171504768" class="anchor"></span>Ilustración 9 Turn
Arround de Peugeot 205 GTI. Xeon Zeuz. peugeot-205-gti-2\[Picture\].
the-blueprints.com.
<https://www.the-blueprints.com/blueprints/cars/peugeot/744/view/peugeot_205_gti/>

Una vez obtenidos todos los turn arounds se ha procedido a modelar los
vehículos. Por simplicidad se ha modelado y hecho el unwrapping de las
UVs de la mitad de la carrocería y se ha aplicado el modificador de
*Mirror* de Blender, que simplifica el proceso de modelado, aunque tal y
como se ha usado, limita el texturizado al ser la misma textura en ambos
lados, no obstante, en relación calidad/tiempo es muy efectivo.

<img src="media/image11.png" style="width:3.8884in;height:2.03611in"
alt="Imagen de la pantalla de un video juego de un carro Descripción generada automáticamente con confianza baja" />

<span id="_Toc171504769" class="anchor"></span>Ilustración 10
Demostración de un modelo 3D de un vehículo previa aplicación del
modificador Mirror de Blender

### Texturizado de los modelos 3D

Una vez creados los modelos 3D de todos los vehículos se han texturizado
pintando sobre los mapas de Uvs exportados de cada modelo, donde además
de la propia pintura del coche, se han dibujado detalles como las
ventanas, faros, parrillas, llantas y en ciertos modelos calcomanías
específicas.

<img src="media/image12.png" style="width:3.37292in;height:3.37292in" />

<span id="_Toc171504770" class="anchor"></span>Ilustración 11 Texturas
dibujadas en Photoshop sobre el mapa de Uvs del modelo

### Creación del prefab de los vehículos en Unity

Una vez se tienen los modelos 3D en Unity y todos los scripts de
simulación listos se ha procedido a crear los prefabs de los vehículos.
En una escena vacía de Unity se ha colocado el modelo 3D del coche y se
le han añadido los siguientes componentes:

- **RigidBody:** Se ha usado este componente para simular el peso de los
  vehículos y además ha sido necesario para poder usar los
  *WheelColliders.*

- **Box Collider:** Se ha usado este componente para darle colisión al
  vehículo, ajustando ésta a los límites del modelo 3D.

- **Audio Source:** Se ha usado este componente para generar el sonido
  del motor.

- **Player Input:** Se ha usado este componente para que se pueda
  controlar el vehículo.

- **Aero Sim Base (Script):** Se ha usado este script, como se explicó
  anteriormente, para simular la aerodinámica del vehículo y también
  porque hay aspectos del script, como son el área frontal y el
  coeficiente de drag, que son relativos de cada coche y se han de
  ajustar en el editor.

- **Wheel Controller (Script):** Se ha usado este componente para
  ajustar las ruedas del modelo 3D a sus respectivos *WheelColliders.*

- **Differential Base (Script):** Se ha usado este componente para
  simular el diferencia<s>r</s>l del vehículo.

También se han añadido los siguientes *gameobjects:*

- **GearBox:** Este es un *gameobject* con un *audioSource* que se usa
  para el sonido al cambiar de marcha, asimismo en los vehículos con
  tracción total se añade el script *Diferential base* para simular el
  diferencial delantero del vehículo.

- **Wheels:** Este es un *gameobject* con cuatro *gameobjects, hechos*
  cada uno con el componente de *WheelCollider,* que son las cuatro
  ruedas físicas del vehículo, denominadas FL, FR, RL, RR haciendo
  referencia a su posición F/R de front y rear y L/R de left y right.

- **Center of Mass:** Es un *gameobject* vacío con un icono solo visible
  en el modo de edición, que se usa como posición para el centro de masa
  del vehículo, el cual es ajustado en el script *Aero Sim Base*. Esto
  se realiza para poder ajustar el centro de masas del *rigidbody* del
  vehículo de forma más visual.

- **Main Camera:** Es la cámara que sigue al vehículo.

- **Front/Rear Roll Bar:** Ambos son *gameobjects* con el script *Anti
  Roll Base* para simular las barras antivuelco frontal y trasera del
  vehículo.

- **Left/Right BL\*:** Ambos son un prefab de luz de punto roja que
  simula las luces de freno de los vehículos que tienen luces de freno.

- **Cameras:** Es un prefab con una serie de *gameobjects* vacíos usados
  como referencia visual de las diferentes posiciones que puede tomar la
  main camera.

<img src="media/image13.png" style="width:5.83968in;height:2.31623in"
alt="Pantalla de computadora con una raqueta de tenis Descripción generada automáticamente con confianza media" />

<span id="_Toc171504771" class="anchor"></span>Ilustración 12 Prefab
completo de un vehículo controlable

## Control del vehículo

Una vez completado la base de los vehículos en Unity se ha creado todo
lo necesario para poder controlar el vehículo. A continuación, se
explica el proceso completo.

### Acciones para controlar el vehículo

Para controlar el vehículo son necesarias las siguientes acciones:

- **Acelerar:** Se encarga de controlar el acelerador del vehículo, toma
  valores *float* entre 0 y 1.

- **Frenar:** Se encarga de controlar el freno del vehículo, toma
  valores *float* entre 0 y 1.

- **Dirección:** Se encarga de controlar el ángulo de la dirección del
  vehículo, toma valores *float* entre -1 y 1.

- **Subir/Bajar marcha:** Son 2 acciones que controlan la marcha en la
  que se encuentra el vehículo, ambas toman valores booleanos.

- **Freno de mano:** Se encarga de controlar el freno de mano del
  vehículo, toma valores *float* entre 0 y 1.

- **Marcha atrás:** Se encarga de cambiar desde cualquier marcha a la
  marcha atrás y desde la marcha atrás a la primera marcha de la
  transmisión, toma valores booleanos.

Otras acciones creadas:

- **Cambiar de cámara:** Se encarga de cambiar entre los diferentes
  tipos de cámaras que tenga el vehículo, toma valores booleanos.

- **Mirar en otras direcciones:** Por cada tipo de cámara se encarga de
  cambiar entre las posiciones de éstas para mirar en las direcciones:
  izquierda, derecha y atrás. Toman valores booleanos

- **Pausa:** Se encarga de parar el gameplay y mostrar el menú de pausa,
  toma valores booleanos.

### Creación del mapa de controles

Una vez definidas las acciones, se ha creado el mapa de controles para
un mando de consola genérico. Para esto se ha tomado como ejemplo los
mapas de controles base de otros juegos de conducción. A continuación,
se muestra un diagrama del mapa de controles creado.

<img src="media/image14.png" style="width:5.87443in;height:2.28465in"
alt="Diagrama Descripción generada automáticamente" />

<span id="_Toc171504772" class="anchor"></span>Ilustración 13 Esquema
del mapa de controles creado. Imágenes originales de Tokyoship,
Wikimedia Commons, CC BY 3.0,
<https://commons.wikimedia.org/w/index.php?curid=24802891>

### Creación del script de control del vehículo

Se ha creado un script llamado *CarController*, el cual maneja toda la
lógica necesaria para conducir el vehículo, y otros aspectos como el
cálculo del ángulo de giro de los neumáticos delanteros o la
implementación del setup del vehículo. A continuación, se explica el
funcionamiento del script.

Principales variables del script:

- **wheels:** Es un array de *WheelColliders* de tamaño cuatro que
  guarda las cuatro ruedas físicas del vehículo.

- **bTorque:** Es un valor *float* usado como el valor total de torque
  de frenada del vehículo y es editable en el editor.

- **scaleFact:** Es un valor *float* arbitrario usado como multiplicador
  del ángulo de giro base calculado y es editable en el editor.

- **FrontDiff/diff:** Ambos son *diferentialBase* usados para guardar el
  diferencial principal del vehículo y en los vehículos con tracción 4x4
  o total el diferencial frontal, solo *FrontDiff* es editable en el
  editor.

- **awdRatio:** Es un valor *float* usado como el ratio en los vehículos
  de tracción 4x4 o total, cuanto torque es pasado al diferencial
  frontal y cuanto al diferencial trasero del vehículo y es editable en
  el editor

- **brakeBias:** Es un valor *float* usado como ratio para distribuir
  entre el eje frontal y trasero el valor de *bTorque* y es editable en
  el editor.

- **powerTrain:** Es un array de tamaño uno de *powerTrains* que guarda
  el tren motriz del *vehiculo*, y es editable en el editor.

- **setup:** Es un array de tamaño uno de setups que guarda setups del
  vehículo, un *scriptable object* que guarda la dureza de las barras
  antivuelco y el tipo de neumáticos del vehículo, y es editable en el
  editor.

- **RearTW/wB:** Ambas variables son valores *float* que se calculan al
  inicio del primer frame de juego, *RearTW* es la distancia entre las
  dos ruedas del eje trasero y *wB* la distancia entre el eje frontal y
  el trasero del vehículo.

- **Max/minPitch:** Ambas variables son valores *float* que definen el
  tono máximo y mínimo que puede tomar el sonido del motor, y son
  editables en el editor.

- **Akermann:** Esta variable de tipo boolenao define si el tipo de la
  geometría de la dirección del vehículo es akermann o anti-akermann, y
  es editable en el editor.

Una vez explicadas las principales variables del script, se pasa a
definir los principales métodos creados:

- **Steering:** Este método realiza el cálculo del ángulo de giro de los
  neumáticos delanteros del vehículo según el tipo de geometría de la
  dirección dada por la variable akermann, para este cálculo usa los
  valores de *RearTW* y *wB*, para posteriormente ser multiplicados por
  el valor de la acción de dirección.

<img src="media/image15.png" style="width:4.16371in;height:3.13159in"
alt="Diagrama Descripción generada automáticamente" />

<span id="_Toc171504773" class="anchor"></span>Ilustración 14 Figura
2-92 de (Jacobson, 2016)

- **setDiffWheels:** Este método dependiendo del tipo de tracción del
  vehículo decide que ruedas del vehículo forman parte del diferencial
  principal del vehículo. Si el vehículo tiene tracción 4x4 o total las
  ruedas delanteras formaran parte de *FrontDiff* y las traseras de
  *diff.*

<span id="_Toc171504837" class="anchor"></span>Código 17 Método
setDiffWheels

- **setSetup:** Este método toma la información de la variable setup y
  las aplica al vehículo, es decir ajusta el valor de las barras
  antivuelco y las curvas de agarre longitudinal y lateral de los 4
  *WheelColliders* del vehículo.

<span id="_Toc171504838" class="anchor"></span>Código 18 Método setSetup

- **BrakeLights:** Este método maneja la lógica de cuando se han de
  encender y apagar las luces de freno del vehículo, éstas solo están
  encendidas cuando el valor de input de freno es mayor que cero.

Seguidamente se explica la lógica completa del script:

- **Inicialización:** Durante la inicialización del script en el método
  *Awake* se ha pasado la variable *wheels* al *powerTrain* junto con la
  variable de la acción de acelerar, se asigna el diferencial principal
  del vehículo a la variable diff, se calcula los valores de *RearTW* y
  *wB* y se llama a los métodos *setSetup* y *setDiffWheels.*

- **Actualización:** Durante el método *Update* del script se llama al
  método *SimulatePowerTrain* del *powerTrain,* se hace una
  interpolación lineal entre *maxPitch* y *minPitch* del pitch del audio
  del motor según el valor de la variable rpm del motor del tren motriz.
  Tras esto se revisa si se ha realizado algunas de las acciones que
  involucran la caja de cambios, es decir, subir marcha, bajar marcha o
  marcha atrás. Si se realiza alguna de estas acciones el valor *Gear*
  de la caja de cambios se ajusta acorde a la acción. Cuando se realizan
  las acciones de subir o bajar marcha, se aumenta o reduce en uno el
  valor de *Gear,* se aleatoriza el valor de pitch del sonido de cambiar
  de marcha y se activa el sonido. En el caso de la acción de marcha
  atrás, cuando esta se realiza, si el valor de *Gear* es distinto al de
  la marcha atrás de la caja de cambios el valor de *Gear* se convierte
  al de la marcha atrás y si se realiza esta acción cuando la caja está
  ya en marcha atrás, el valor de *Gear* se ajusta al de la primera
  marcha de la caja de cambios.

> Una vez revisada la lógica de la caja de cambios se revisa la lógica
> del diferencial, donde se revisa si la caja está en neutral o no, si
> no está en neutral y el tipo de tracción no es 4x4 o total se llama al
> método *DistibuteTorque* de la variable *diff* con el valor de
> multiplicar los valores devueltos por los métodos *GetRange* del
> motor, *GetGearing* de la caja de cambios y el valor de la acción de
> acelerar. En el caso de vehículos de tracción 4x4 o total se realiza
> el mismo calculo, pero al valor pasado a la variable *diff* se
> multiplica también por el valor de *awdRatio* y al valor pasado a
> *FrontDiff* se multiplica por 1-awdRatio.
>
> A continuación, se llama al método *Steering* para realizar el cálculo
> del ángulo de giro de los neumáticos y se maneja la lógica de los
> frenos del vehículo. Se llama al método *BrakeLights* donde el torque
> de frenada del eje delantero se calcula multiplicando el valor de
> *bTorque* por el valor de *brakeBias* y por el valor devuelto por la
> acción de frenar. Para el eje trasero se revisa si el valor del freno
> de mano es mayor que cero, si es así el torque de frenada del eje
> trasero es infinito, boqueando el giro de los neumáticos, y si no el
> valor del torque de frenada se calcula multiplicando el valor de
> *bTorque* por 1-*brakeBias* y por el valor devuelto por la acción de
> frenar.

Una vez completo el script se ha completado la creación del control de
los vehículos en Unity.

## Creación de un circuito

Completados los vehículos se ha procedido a elegir un circuito para
poder probar los diferentes vehículos y tener diferentes terrenos. Se ha
elegido el circuito real Hockenheimring debido a que tiene una gran
variedad de tipos de curvas y rectas largas, donde se pueden demostrar
las diferentes dinámicas de los vehículos, aunque le falten cambios de
altura relevantes. En los siguientes apartados se describe el proceso de
creación del circuito.

### Creación del modelo 3D del circuito

Se ha usado de referencia la imagen del trazado posterior a la reforma
de 2002 (Sentoan, 2012), ésta se llevó a Blender , se usó un grid y se
fue dando la forma del circuito. Para poder correlacionar las distancias
del circuito real y el modelo 3D se han usado la herramienta de la regla
de Google maps y la regla de Blender.

Una vez hecha la pista completa, primero se han creado los pianos
siguiendo aproximadamente los existentes en el circuito. Los pianos se
han generado realizando cortes en la malla de la pista, se ha hecho una
extrusión de estas zonas cortadas, para posteriormente rellenar la zona
interior y exterior de la pista. Para la zona interior se han
seleccionado los vértices interiores de la pista y se ha creado una cara
automáticamente, para después triangularla con Ctrl+T. Para la zona
exterior se han seleccionado los bordes exteriores de la pista y se ha
realizado una extrusión de éstos para posteriormente escalarlos,
generando así las zonas fuera de la pista. Además, se ha creado el
modelo 3D de un muro con una valla y se ha colocado para delimitar el
circuito.

Los mapas de Uvs del circuito se han realizado con la opción *Proyect
from View* de unwrap de Blender.

### Texturizado del modelo 3D del circuito

Para la textura del asfalto se ha usado el patrón de “pincel sobre
lienzo” en Photoshop en una imagen cuadrada de 1024x1024 pixeles y el
color se le da en el material de Unity.

Para la textura de la grava se ha usado una textura llamada *wall
texture with cartoon stones* por **0melapics** de la página web de
Freepik (0melapics, s.f.), la cual se ha modificado para poder elegir
manualmente el color de la textura en el material de Unity, para ello se
ha convertido a escala de grises en Photoshop.

En los muros y postes se han usado texturas planas, y para las valla se
ha hecho una textura de líneas cruzadas con trasparencias.

# Interfaz de usuario

## Selector de vehículos

Una vez implementado el circuito se ha decidido crear una pantalla de
selección de vehículo, creando una nueva escena de Unity donde se ha
colocado un cilindro aplanado al que se le ha añadido un *Rigidbody*, un
Player Input y dos nuevos scripts que se explican a continuación:

- **Rot Car Select:** Este script se encarga de rotar el cilindro sobre
  el eje Y usando el *RigidBody* del mismo para darle una velocidad
  angular *rotSpeed,* que es una variable *float* editable desde el
  editor.

- **Car Selector:** Este script se encarga de colocar el modelo 3D del
  vehículo que se va a seleccionar sobre el cilindro, manejar el cambio
  de información sobre el vehículo en el canvas de la escena y cargar la
  escena con el circuito. A continuación, se explica en detalle la
  estructura del script.

> Estas son las principales variables del script

- **carSelected:** es una variable estática de tipo *int* que representa
  el coche seleccionado por el jugador.

- **cars:** es un array de *strings* que contiene las direcciones a cada
  prefab de cada vehículo.

- **canvas:** es una variable de tipo *SlctCarCanvasManager* que
  contiene el script que maneja la información que se muestra en el
  canvas de la escena.

- **uiAudio:** es una variable de tipo *AudioManager* que contiene el
  script que maneja los efectos de sonido en el selector de coches.

> A continuación, se explica el único método creado en este script:

- **SpawnCar:** Este método toma el valor de *carSelected* y carga en
  memoria el vehículo desde la dirección dada por la posición
  *carSelected* en el array car y lo instancia como hijo del cilindro de
  la escena.

<span id="_Toc171504839" class="anchor"></span>Código 19 Funcionamiento
del instanciador de vehículos en el selector

> Expuestas las principales variables y métodos del script se va a
> explicar la lógica de éste:

- **Inicialización:** Durante la inicialización del script se referencia
  al *gameObject* del cilindro en la variable *cilinderBase* y se
  guardan todas las direcciones de los prefabs de los vehículos del
  selector en el array cars con el método *AssetDatabase.FindAssets*.
  Aparte se llama al método *SpawnCar* para colocar el primer vehículo
  en la escena.

<span id="_Toc171504840" class="anchor"></span>Código 20 Carga en
memoria de los prefabs del selector de vehículos

- **Actualización:** Durante el método *Update* se revisa si la acción
  de reducir *carSelected* se activa y si *carSelected* no está fuera
  del tamaño del array car, si es así se reduce en 1 el valor de
  *carSelected,* se destruye el vehículo actual, se instancia el nuevo,
  se llama al método *ChangedData* del canvas manager y se llama al
  método *playSound* con el valor 0 del audio manager. La acción de
  aumentar el valor de carSelected sigue el mismo proceso previamente
  descrito, pero aumentado en 1 el valor de *carSelected.* Tras revisar
  estas dos acciones se revisa si se activa la acción de confirmar el
  vehículo, la cual llama al método *playSound* con el valor 1 del audio
  manager y carga la escena con el circuito.

### Prefab de los vehículos del selector.

Para el selector se usan unos prebafs de vehículos diferentes a los
usados durante la conducción. Éstos se han creado usando el modelo 3D
del vehículo y un *scriptable object* llamado *Select Screen Car Base*
que guarda toda la información del vehículo que se muestra en el canvas,
además de la posición y escalas del modelo 3D ya que al ser instanciados
como hijos del cilindro la escala de los modelos varía.

La información guardada es la siguiente:

- **carName:** Es una variable de tipo *string* que define el nombre del
  vehículo.

- **enginePos:** Es una variable de tipo *string* que define la posición
  del motor.

- **hp:** Es una variable de tipo *int* que define la potencia del motor
  en Caballos de vapor.

- **selectScreenPos/scale:** Son dos variables de tipo *Vector3* que
  guardan la posición y escala del modelo 3D con respecto al cilindro.

- **tractionType:** Es una variable de tipo *string* que toma el valor
  de la variable tractionType de la caja de cambios para elegir que
  *string* mostrar entre “FWD”, “RWD” y “AWD”.

Esta selección de la *string* del tipo de tracción que usa el vehículo
se realiza en el método de inicialización *Start* del script junto con
el ajuste de la posición y escala del modelo del vehículo.

### Canvas del selector de vehículos

El canvas de la pantalla de selección de vehículo tiene tres cuadros de
texto que muestran el nombre, la potencia y el tipo de tracción del
vehículo. También se ha creado una imagen para la zona inferior de la
pantalla que delimita la zona donde se muestra esta información del
vehículo, y además se han colocado los *audio sources* que contienen los
efectos de sonido del selector.

<img src="media/image16.png" style="width:2.55903in;height:1.47348in"
alt="Gráfico, Gráfico de rectángulos Descripción generada automáticamente" />

<span id="_Toc171504774" class="anchor"></span>Ilustración 15 Canvas del
menú del selector de vehículos

Asimismo, se ha configurado el canvas para que escale según el tamaño de
la pantalla, teniendo en cuenta así diferentes resoluciones y aspect
ratios de diferentes pantallas.

#### Select Car Canvas Manager

Para manejar la información que se muestra en el canvas se ha creado un
script llamado *SlctCarCanvasManager*, en el cual se ha creado el método
*ChangeData* que coje el primer hijo del cilindro de la escena, el
prefab del vehículo en el selector y guarda en una variable llamada
*carData* toda la información del script *SelectScreenCarBase.* A
continuación, va cuadro de texto por cuadro de texto cambiando el valor
del texto por la información del vehículo requerida en cada cuadro.

<span id="_Toc171504841" class="anchor"></span>Código 21 Método
ChangedData

### Audio Manager del selector de vehículos

Para reproducir los diferentes efectos de sonido del selector de
vehículos se ha creado un pequeño script que maneja que efecto de sonido
se ha de reproducir dependiendo de con que valor se llama al método
creado, *PlaySound*. El script tiene un array de *audio sources* con
todos los sonidos de la interfaz y el método *PlaySound* reproduce el
*audio source* correspondiente al número con el que se llama a la
función en array.

<span id="_Toc171504842" class="anchor"></span>Código 22 Método
playSound

## Spawner de vehículos

Para poder instanciar el vehículo seleccionado en la escena con el
circuito se ha creado un script llamado *Player Car Spawner.* Este
script toma el valor de la variable *carSelected* del script Car
Selector y usando el mismo método de carga de assets que en el selector
de vehículos, instancia el prefab del vehículo controlable
correspondiente en la escena.

<span id="_Toc171504843" class="anchor"></span>Código 23 Inicialización
del script Player Car Spawner

Hay que tener cuidado con esta implementación debido a que ésta es
dependiente de que el orden de los prebafs de vehículos del selector sea
el mismo que el de los controlables, porque si no fuera así no
funcionaria.

Una vez creado el script se añade a un *gameObject* vacío y se coloca
éste pasada la línea de meta del circuito.

## Interfaz de conducción

Una vez tenemos el sistema de selección de vehículos se ha creado la
interfaz que acompaña a la conducción del vehículo. Una interfaz simple
y limpia que muestra la velocidad del vehículo, la marcha en la que se
encuentra la caja de cambios, las revoluciones por minuto del motor y
los inputs de dirección, acelerador y freno del jugador.

<img src="media/image17.png" style="width:5.90556in;height:2.55625in"
alt="Interfaz de usuario gráfica Descripción generada automáticamente con confianza media" />

<span id="_Toc171504775" class="anchor"></span>Ilustración 16 Canvas de
la interfaz de conducción

### Creación de los elementos visuales

Para la creación del tacómetro se ha usado la herramienta de elipse en
Photoshop para generar tanto el circulo interior como la zona exterior.
Igualmene se ha creado un “negativo” de la zona exterior para usarla de
relleno. Ambas partes se han generado en blanco para poder ajustar el
color posteriormente en Unity.

<img src="media/image18.png" style="width:3.04867in;height:2.03592in"
alt="Forma Descripción generada automáticamente" />

<span id="_Toc171504776" class="anchor"></span>Ilustración 17 tacómetro
creado en Photoshop

Para el resto de los elementos usa una textura plana de 1024X1024
transformada.

### Implementación de los elementos visuales en Unity

Para las barras que muestran los inputs, se ha usado la textura plana
sobre una imagen vacía. La textura se ha ajustado a la imagen vacía con
el *Anchor Preset Stretch,* espaciándola en 2 pixeles en todas las
direcciones. Por otro lado se ha configurado la imagen como imagen de
tipo *Filled Vertical* para poder ajustar posteriormente el *Fill
Amount* desde código. Para cada tipo de input se ha seleccionado un
color diferente de la textura: el acelerado es verde, el freno es rojo y
la dirección es amarilla.

<img src="media/image19.png" style="width:2.06326in;height:1.81816in"
alt="Gráfico, Gráfico de rectángulos Descripción generada automáticamente" />

<span id="_Toc171504777" class="anchor"></span>Ilustración 18 Barras de
los inputs de acelerador, freno y dirección

Para el tacómetro se ha usado un método similar a las barras, pero la
imagen de relleno se ha configurado como *Filled Radial 180* dando lugar
al efecto de barrido de la imagen de relleno. También se han colocado
tres cuadros de texto dentro del círculo principal del tacómetro para
mostrar numéricamente los datos previamente mencionados.

<img src="media/image20.png" style="width:1.93489in;height:2.01924in"
alt="Imagen que contiene Interfaz de usuario gráfica Descripción generada automáticamente" />

<span id="_Toc171504778" class="anchor"></span>Ilustración 19 tacómetro
implementado en Unity

### Canvas Manager

Una vez implementados todos los elementos de la interfaz se ha creado un
script llamado *Canvas Manager* que controla la información mostrada por
los elementos creados. El funcionamiento del script es el que se
describe a continuación.

Principales variables del script:

- **Imágenes:** Son diferentes variables de tipo *Image,* que guardan
  las imágenes de tipo *Filler* previamente mencionadas.

- **MotorT/speed/Gear:** Son tres variables de tipo *TextMeshProUGUI,*
  que guardan los tres cuadros de texto que están dentro de del
  tacómetro.

- **PowerTrain:** Es una variable de tipo *powerTrain* que guarda el
  tren motriz del vehículo del jugador.

- **playerCar:** Es una variable de tipo *GameObject* que guarda el
  *gameobject* del vehículo del jugador.

- **TacBase/TacFinal:** Son 2 variables de tipo *Color*, que definen el
  color inicial del relleno del tacómetro y el color final.

Seguidamente se explica la lógica del script:

- **Inicialización:** En el método *Start* del script se busca en la
  escena el *gameObject* del vehículo del jugador el cual está
  identificado con el tag *Player*, aparte se guarda el *CarController*
  del vehículo en la variable *playerCarC* y el tren motriz en la
  variable *powerTrain.*

- **Actualización:** En el método *Update* del script primero se calcula
  la velocidad del vehículo con la siguiente formula: rpm del motor
  entre el ratio de la caja de cambios y el diferencial y todo esto
  multiplicado por dos por el radio de los neumáticos del vehículo y por
  0.1885, esto se redondea a un número entero y el valor se le pasa al
  cuadro de texto *speed*. A continuación, se redondea el valor de las
  revoluciones por minuto del motor a un número entero y se le pasa al
  cuadro de texto *gear,* aparte se ajusta el *fillAmount* de las
  imágenes del input del acelerador, el freno y el *fillAmount* del
  tacómetro se calcula haciendo una interpolación lineal entre 0-1 de
  las revoluciones por minuto a las que está girando el motor, también
  se hace una interpolación lineal entre los colores *TacBase* y
  *TacFinal* con la función *Color.Lerp* para determinar el color del
  tacómetro según el *fillAmount* del propio tacómetro.

> Posteriormente se revisa el valor de la entrada de la dirección y se
> ajusta el *fillAmount* de las imágenes designadas según éste.

<span id="_Toc171504844" class="anchor"></span>Código 24 Funcionamiento
de la visualización del input de dirección

> Finalmente se revisa en que marcha se encuentra la caja de cambios, y,
> según el valor, existen 3 posibilidades: *primero*, el valor es -1 lo
> cual significa que la caja de cambios está en punto muerto y el valor
> del cuadro de texto es “N”, *segundo*, el valor no es -1 y no es la
> última marcha del array de marchas, el valor del cuadro de texto es
> igual al valor de la caja de cambios más uno y *tercero*, es la última
> marcha del array, en ese caso la caja de cambios está en marcha atrás
> y el valor del cuadro de texto es “R”.

<span id="_Toc171504845" class="anchor"></span>Código 25 Funcionamiento
de la visualización de la marcha seleccionada en la caja de cambios

## Sistema de tiempos

Para el sistema de tiempos se ha creado un sistema basado en tres
sectores similar a la mayoría de videojuegos de conducción, donde el
circuito se divide en tres zonas cada una con una zona de detección que
determina si el jugador está yendo más rápido o no en su vuelta.

Para ello se ha creado un prefab que delimita esa zona de detección, y
varios scripts que manejan el sistema de tiempos y el cómo se muestran
en pantalla.

<img src="media/image21.png" style="width:4.80481in;height:2.20884in"
alt="Gráfico Descripción generada automáticamente con confianza media" />

<span id="_Toc171504779" class="anchor"></span>Ilustración 20 Interfaz
de tiempos de la interfaz de conducción

### Prebaf de la zona de detección

La zona de detección es un plano blanco escalado que simula una marca de
pintura en el circuito, el cual tiene un *box Collider* configurado como
*trigger* y el script *Sec Check* que maneja la entrada en el *box
Collider* del coche del jugador.

<img src="media/image22.png" style="width:2.75931in;height:2.16845in"
alt="Interfaz de usuario gráfica, Aplicación Descripción generada automáticamente" />

<span id="_Toc171504780" class="anchor"></span>Ilustración 21 Prefab de
la zona de detección de tiempos

### Scripts del sistema de tiempo

El principal script que maneja la lógica general del sistema de tiempos
es *TimeManager*, cuyo propósito principal es avanzar el contador de
tiempo, manejar el sistema de sectores y la lógica al completar la
vuelta. A continuación, se explica el funcionamiento del script en
detalle.

Las principales variables de *TimeManager* son:

- **AcSec:** Es una variable de tipo *int* que representa el sector en
  el que se encuentra el jugador.

- **Time:** Es una variable de tipo *float* que guarda el tiempo de la
  vuelta actual.

- **TimeMin/Sec/Dsec:** Son tres variables de tipo *float* usadas para
  mostrar el tiempo en formato de minutos, segundos y décimas de
  segundo.

- **Latest/LastLap:** Son dos variables de tipo *float* usadas para
  guardar el tiempo de la vuelta anterior, se usa *LatestLap* como
  variable auxiliar para comparar el tiempo de la vuelta que se acaba de
  terminar con el tiempo de la vuelta anterior.

- **TimerSectors:** Es un array de *floats* que guarda el tiempo de cada
  sector.

- **LastLapSectors:** Es un array de *floats* que guarda el tiempo de
  los sectores de la vuelta anterior.

- **VisTime:** Es una variable de tipo *TimeVisual* que guarda el script
  de mismo nombre, cuyo propósito es manejar como se muestra en el
  canvas el tiempo de vuelta.

Los métodos creados para *TimeManager* son los siguientes:

- **Timer:** Este método se encarga de sumar el valor de
  *Time.deltaTime* a la variable time.

- **TimerComponents:** Este método recibe un valor de tiempo *float* en
  segundos y lo devuelve como *string* en formato minutos, segundos y
  décimas de segundo.

<span id="_Toc171504846" class="anchor"></span>Código 26 Método
TimerComponents

- **NextSec:** Este método aumenta el valor de *acSec* en uno
  dependiendo del sector, calcula el tiempo de ese sector para
  posteriormente guardarlo en *timerSector* y llamar al método
  *VisTime.SectorUpdate.*

> Cuando se termina el primer sector el tiempo guardado en *timerSector*
> es el tiempo de vuelta actual, si se termina el segundo sector el
> tiempo guardado es el tiempo actual de vuelta menos el tiempo del
> primer sector y cuando se termina el ultimo sector el tiempo guardado
> es el tiempo actual menos la suma del tiempo de los sectores uno y
> dos.

<span id="_Toc171504847" class="anchor"></span>Código 27 Método nextSec

- **NextLap:** Este método guarda el tiempo actual en *latestLap,*
  posteriormente llama a *nextSec* y se guardan los valores de los
  *timerSectors* en *lastLapSectors,* finalmente se llama al método
  *VisTime.LastLapUpdater*, se guarda el valor de *lastestLap* en
  *lastLap* y se reinician los valores de *acSec* a uno y time a cero.

<span id="_Toc171504848" class="anchor"></span>Código 28 Método NextLap

La lógica que sigue el script *Time Manager* es muy simple,
inicializando *lastLapSectors* a infinito en el método *Start* y en la
actualización se llama al método *Timer.*

El siguiente script que se va a explicar es *Time Visual* el cual maneja
como se muestra en pantalla el tiempo de vuelta y el tiempo por
sectores.

Las principales variables de *Time Visual* son:

- **Ac/LastLap:** Son dos variables de tipo *TextMeshProUGUI* que
  guardan los cuadros de texto que muestran el tiempo de vuelta actual y
  el tiempo de la vuelta anterior.

- **Sectors:** Es un array de tipo *TextMeshProUGUI* que guarda los
  cuadros de texto que muestran el tiempo de cada sector.

- **Time:** Es una variable de tipo *TimeManager* que guarda la
  información del script *Time Manager*.

Los métodos de *Time Visual* son:

- **LastLapUpdater:** Este método coloca en el cuadro de texto *lastLap*
  el valor devuelto por *time.TimerComponents* al cual se le pasa el
  valor de *lastestLap*. Además cambia el color del texto dependiendo si
  el valor de *time.lastestLap* es mayor o menor que *time.lastLap,* si
  es menor cambia el color a verde y si es mayor a rojo.

<span id="_Toc171504849" class="anchor"></span>Código 29 Método
LastLapUpdater

- **SectorUpdater:** Este método recibe como valor un *int* llamado
  **i** que representa el sector a actualizar que cambia el valor del
  cuadro de texto del sector **i** al devuelto por el método
  *time.TimerComponents,* al que se le pasa el valor de tiempo del
  sector **i** guardado en la variable *timeSector* de time, aparte se
  llama al método *ColorSec* con el valor de **i**.

<span id="_Toc171504850" class="anchor"></span>Código 30 Método
SectorUpdater

- **ColorSec:** Este método recibe como valor un *int* llamado **i** que
  representa el sector que se actualiza y revisa si el tiempo de sector
  de esta vuelta es mayor o menor que el tiempo del mismo sector en la
  vuelta anterior, si es mayor se cambia el color del cuadro de texto a
  rojo y si es menor se cambia el color del cuadro de texto a verde.

<span id="_Toc171504851" class="anchor"></span>Código 31 Método ColorSec

La lógica que sigue este script es de nuevo bastante simple,
actualizando en el método *Update* el valor del cuadro de texto *acLap*
con el valor devuelto por *TimerComponets* al llamarlo con el valor time
del Time Manager.

El ultimo script creado para manejar el sistema de tiempos es el *Sec
Check* el cual tiene tres variables y un método *OnTriggerEnter* de
Unity.

Las variables de *Sec Check* son:

- **Timer:** Es una variable de *Time Manager* que guarda la información
  del script Time Manager.

- **Position:** Es una variable de tipo *int* que representa el sector
  del cual es zona de detección.

- **IsFinish:** Es una variable de tipo *bool* que representa si la zona
  de detección del sector también es el final de la vuelta.

El método *OnTriggerEnter* revisa si el tag del objeto que colisiona con
el *box collider* es el del jugador, si es así revisa que la zona de
detección es el final de la vuelta o no, si no es el final de la vuelta
revisa que el sector actual y el valor de position sean el mismo y si es
así se llama al método *nextSect* de Time Manager. Si la zona de
detección corresponde con el final de la vuelta se llama al método
*nextLap* de Time Manager.

<span id="_Toc171504852" class="anchor"></span>Código 32 Método
OnTriggerEnter del script SecCheck

## Menú de pausa

Para finalizar se ha creado un menú de pausa simple que permite
reiniciar la sesión actual con el mismo vehículo y volver al selector de
vehículo. Para ello se ha creado un prefab de un canvas el cual oscurece
la pantalla y muestra un botón para cada acción previamente mencionada,
aparte de un script *Pause Manager* que maneja la lógica del menú y la
pausa del juego.

<img src="media/image23.png" style="width:4.81183in;height:2.71373in"
alt="Interfaz de usuario gráfica Descripción generada automáticamente" />

<span id="_Toc171504781" class="anchor"></span>Ilustración 22 Canvas del
menú de pausa

### Pause Manager

Este script maneja la pausa de juego, activando el canvas del menú de
pausa y parando el gameplay. A continuación, se explica su
funcionamiento.

Las variables principales del script son las siguientes:

- **PauseMenu:** Esta variable de tipo canvas guarda la información del
  canvas del menú de pausa.

- **uiAudio:** Esta variable de tipo *AudioManager* guarda la
  información del *AudioManager* del *GameManager*.

- **pause:** Esta variable de tipo *InputAction* guarda la acción de
  pausar previamente creada en el mapeo de controles.

Los métodos creados para este script son los siguientes:

- **ToCarSelect:** Este método reproduce el sonido de confirmación
  llamando al método *playSound* de *uiAudio* con el valor 1, cambia el
  *timeScale* del juego a uno ya que al pausar el juego el *timeScale*
  se cambia a 0 y finalmente se llama al método *LoadScene* del
  *SceneManager* con el valor de la escena del selector de vehículos.

- **Restart:** Este método es igual que *ToCarSelect* pero se llama a
  *LoadScene* con el valor de la escena actual.

En el método de actualización del script se revisa si se ha realizado la
acción de pausa y el menú de pausa esta activo, si es así se desactiva
el menú de pausa, se ajusta el *timeScale* a uno y se reproduce el
sonido de “unpause” llamando al método *playSound* de *uiAudio* con el
valor 4. Si se realiza la acción con el menú inactivo, éste se activa,
se ajusta el *timeScale* a 0 y se reproduce el sonido de “pause”
llamando al método *playSound* de *uiAudio* con el valor 3.

<span id="_Toc171504853" class="anchor"></span>Código 33 Método Update
del script PauseManager

## Game Manager

Para manejar la lógica de ciertos elementos externos al jugador como son
el manejo del tiempo, el menú de pausa y los sonidos de la interfaz, se
ha creado un *gameObject* vacío con los scripts pertinentes, el *Time
Manager, Audio Manager* y *Pause Manager.*

# Conclusiones

## Introducción

Una vez completados todos los elementos de simulación y control del
vehículo, diferentes vehículos, un circuito y diferentes interfaces, se
ha dado por completada esta fase del proyecto, donde se tiene un modelo
de físicas que aproximadamente simula las dinámicas de un vehículo, cuya
sensación es realista, pero a la vez accesible a ser jugada con un
mando. También se tiene una primera aproximación al estilo visual
deseado para el proyecto usando el paquete experimental *Unity Toon
Shader*. Se ha buscado una estética Cell-Shaded, por preferencia
personal, así como crear una diferenciación con la gran mayoría de
juegos de conducción simcade actuales, que buscan una estética
hiperrealista con reminiscencia de juegos como Auto-Modellista, y si
bien este proyecto actualmente está lejos, es una clara inspiración.

<img src="media/image24.png" style="width:5.90556in;height:1.90486in"
alt="Imagen de la pantalla de un video juego de una carretera Descripción generada automáticamente con confianza media" />

<span id="_Toc171504782" class="anchor"></span>Ilustración 23
Comparativa entre Auto-Modellista y este proyecto

## Funcionalidad Implementada

- **Modelo de físicas:** Se han implementado todos los módulos
  propuestos en los objetivos de la memoria.

  - **Motor:** El motor del vehículo se ha simplificado a una curva de
    torque según revoluciones por minuto, la cual se ha implementado en
    intervalos de quinientas revoluciones por minuto, y una inercia de
    giro del motor.

> <span id="_Toc170425314" class="anchor"></span>Gráfica 3 Curva de
> torque del Mercedes 190E EVO II DTM

- **Transmisión:** La transmisión se ha simplificado a un array de
  ratios por marcha en la caja y el ratio del diferencial.

> <span id="_Toc170425315" class="anchor"></span>Gráfica 4 Velocidad por
> marcha del Mercedes 190E EVO II DTM

- **Diferencial:** Simular un diferencial es una de las mayores
  madrigueras de conejo de los modelos de físicas de conducción. Se ha
  decidido simplificarlo en tres tipos de diferenciales, cuya simulación
  se ha simplificado en gran medida ajustando la cantidad de torque que
  se transfiere a cada rueda dependiendo de la resistencia longitudinal
  generada en cada neumático. Esto da lugar a un diferencial abierto con
  un comportamiento bastante similar al real, pero en el resto de los
  tipos de diferencial da como resultado comportamientos relativamente
  semejantes.

- **Suspensión:** Para la implementación de la suspensión se ha confiado
  en la implementación realizada por el propio Unity en el
  WheelCollider, el cual usa PhysX 4.1 Vehicles SDK para simular el
  conjunto de suspensión y neumático. Se ha demostrado que, con la
  configuración correcta y la implementación de barras antivuelco, se
  puede crear un sistema de suspensiones creíble y aproximado a la
  realidad.

- **Neumáticos:** De nuevo, con el uso de WheelCollider se ha dejado la
  implementación de los neumáticos al propio Unity, y se han configurado
  las curvas de agarre de cada tipo de neumático en base a la curva de
  agarre del neumático base creado usando como referencia la figura 1 de
  (Choi, 2008).

> <img src="media/image25.png" style="width:4.38255in;height:2.55872in"
> alt="Typical tire longitudinal friction-slip curves. " />
>
> <span id="_Toc171504783" class="anchor"></span>Ilustración 24 Figura 1
> del Artículo de Seibum Choi
>
> <span id="_Toc171504784" class="anchor"></span>Ilustración 25 Curva de
> agarre longitudinal de los neumáticos base
>
> Las curvas se asemejan, pero por el diseño de las curvas de agarre del
> WheelCollider a partir del punto Asymtote la curva el agarre es
> lineal.
>
> <img src="media/image26.png" style="width:3.26667in;height:1.85in" />
>
> <span id="_Toc171504785" class="anchor"></span>Ilustración 26 Curva de
> agarre de demostración en la documentación del WheelCollider

- **Aerodinámica:** La simulación de la aerodinámica se ha simplificado
  de forma que se aplica la fórmula de resistencia aerodinámica usando
  solo los coeficientes aerodinámicos y área superficial del frontal del
  vehículo.

> <img src="media/image27.png" style="width:3.20881in;height:2.86582in"
> alt="Imagen de la pantalla de un video juego Descripción generada automáticamente con confianza media" />
>
> <span id="_Toc171504786" class="anchor"></span>Ilustración 27 Medidas
> tomadas para calcular el área frontal de cada vehículo
>
> La carga aerodinámica también se ha simplificado para que toda la
> carga generada afecte uniformemente a todo el vehículo, en vez de
> separarla por zonas, como se hace en juegos de simulación como Assetto
> Corsa, y aplicar la carga en las diferentes zonas. Aun así,
> simplificando toda la carga generada para que afecte uniformemente a
> todo el vehículo, se consigue un efecto de carga aerodinámica creíble.
>
> <img src="media/image28.png" style="width:4.85398in;height:2.71409in"
> alt="Imagen de la pantalla de un video juego de un carro Descripción generada automáticamente con confianza media" />
>
> <span id="_Toc171504787" class="anchor"></span>Ilustración 28 Zonas de
> carga aerodinámica en el Mercedes 190E EVO II DTM en Assetto Corsa

- **Interfaz de usuario:** Se han implementado varias interfaces de
  usuario que muestran información en tiempo real de los inputs del
  jugador, la información necesaria del vehículo y el tiempo por vuelta,
  además de los diferentes menús de pausa y selección de vehículo.

> <img src="media/image29.png" style="width:5.27826in;height:8.87569in"
> alt="Interfaz de usuario gráfica Descripción generada automáticamente" />

<span id="_Toc171504788" class="anchor"></span>Ilustración 29
Demostración de las interfaces creadas

## Mejoras a futuro y problemas actuales

En la implementación actual existe el problema de que en algunos casos
los cambios de marcha se duplican, es decir, pulsar el botón de subir o
bajar marcha realiza dos veces la acción y se cambian 2 marchas a la
vez.

Existe una larga lista de mejoras y sistemas a implementar:

- Implementación de control de tracción y ABS.

- Submenú en la interfaz de conducción que permita realizar ajustes en
  el balance de frenos, el control de tracción, nivel de ABS o sistemas
  específicos de cada coche como ajustar la altura y dureza de la
  suspensión (similar al de Gran Turismo 7).

<img src="media/image30.jpeg" style="width:5.15532in;height:1.98403in"
alt="Una carretera con coches Descripción generada automáticamente" />

<span id="_Toc171504789" class="anchor"></span>Ilustración 30 Submenú de
ajuste de Control de tracción de la interfaz de Gran Turismo 7

- Rehacer la implementación del sistema de Setups, junto con una
  interfaz que permita ajustarlos en tiempo de ejecución y guardarlos,
  además de poder ajustar dureza de los muelles y amortiguadores de la
  suspensión, barras antivuelco, ratios de la caja de cambios y carga
  aerodinámica.

- Rehacer la implementación del diferencial, ya que como bien se ha
  explicado anteriormente, la implementación actual deja mucho que
  desear a la hora de simular diferenciales que no sean abiertos.

# Bibliografía

**(0melapics, s.f.)** 0melapics. (s.f.). *Freepick*. Recuperado el 5 de
Marzo de 2024, de Freepick:
https://www.freepik.com/free-vector/wall-texture-with-cartoon-stones_1064416.htm#query=cartoon%20ground%20texture&position=26&from_view=keyword&track=ais&uuid=c004d360-245b-4acc-9b15-2e20d4cd3983

**(Choi, 2008)** Choi, S. B. (31 de Marzo de 2008). Antilock Brake
System With a Continuous Wheel Slip Control to Maximize the Braking
Performance and the Ride Quality. *IEEE Transactions on Control Systems
Technology , 16*(5), 996 - 1003. doi:10.1109/TCST.2007.916308

**(Edy, 2017)** Edy. (7 de Noviembre de 2017). *How to make a physically
real stable car with WheelColliders*. Obtenido de Unity Forums:
https://forum.unity.com/threads/how-to-make-a-physically-real-stable-car-with-wheelcolliders.50643/

**(Ferrari F1 Formula 1 F2004, s.f.)** *Ferrari F1 Formula 1 F2004*.
(s.f.). Recuperado el 20 de Febrero de 2024, de The-Blueprints.com:
https://www.the-blueprints.com/vectordrawings/show/22275/ferrari_f1_formula_1_f2004/

**(Horsepower and Torque curve for 1985 Peugeot 205 Turbo 16 Evolution
2, s.f.)** *Horsepower and Torque curve for 1985 Peugeot 205 Turbo 16
Evolution 2*. (s.f.). Recuperado el 18 de Febrero de 2024, de Automotive
Catalog:
https://www.automobile-catalog.com/curve/1985/2574935/peugeot_205_turbo_16_evolution_2.html

**(Horsepower and Torque curve for 1990 Mercedes-Benz 190 E 2.5-16
Evolution II, s.f.)** *Horsepower and Torque curve for 1990
Mercedes-Benz 190 E 2.5-16 Evolution II*. (s.f.). Recuperado el 15 de
Febrero de 2024, de Automobile Catalog:
https://www.automobile-catalog.com/curve/1990/1479110/mercedes-benz_190_e_2_5-16_evolution_ii.html

**(Horsepower and Torque curve for 1990 Peugeot 205 GTI 1.9, s.f.)**
*Horsepower and Torque curve for 1990 Peugeot 205 GTI 1.9*. (s.f.).
Recuperado el 13 de Febrero de 2024, de Automobile Catalog:
https://www.automobile-catalog.com/curve/1990/63185/peugeot_205_gti_1_9.html

**(Jacobson, 2016)** Jacobson, B. (2016). *Vehicle dynamics.* Chalmers
University of Technology. Obtenido de
https://research.chalmers.se/publication/520229/file/520229_Fulltext.pdf

**(Mercedes-Benz 190E Evolution II w201, s.f.)** *Mercedes-Benz 190E
Evolution II w201*. (s.f.). Recuperado el 15 de Febrero de 2024, de
The-Blueprints.com:
https://www.the-blueprints.com/blueprints/cars/mercedes/590/view/mercedes-benz_190_e_evolution_ii_w201_1989/

**(Mundo, Gencarelli, Dramisino, & Garre, 2019)** Mundo, D., Gencarelli,
R., Dramisino, L., & Garre, C. (2019). Development, Validation and RT
Performance Assessment of a Platform for Driver-in-the-Loop Simulation
of Vehicle Dynamics. En *Advances in Italian Mechanism Science.*
Springer International Publishing. doi:10.1007/978-3-030-03320-0_14

**(Peugeot 205 GTi, s.f.)** *Peugeot 205 GTi*. (s.f.). Recuperado el 13
de Febrero de 2024, de The-Blueprints.com:
https://www.the-blueprints.com/blueprints/cars/peugeot/744/view/peugeot_205_gti/

**(Peugeot 205 Turbo 16, s.f.)** *Peugeot 205 Turbo 16*. (s.f.).
Recuperado el 18 de Febrero de 2024, de The-Blueprints:
https://www.the-blueprints.com/vectordrawings/show/1677/peugeot_205_turbo_16/

**(Sentoan, 2012)** Sentoan. (9 de Julio de 2012).
*File:Hokenheim2012.svg*. Obtenido de Wikipedia Commons:
https://commons.wikimedia.org/wiki/File:Hockenheim2012.svg
