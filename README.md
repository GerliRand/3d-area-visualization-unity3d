## 3D Area Visualization with Unity
Digital Twins course project.
Visualizes a selected area in Unity using a heightmap (RAW) and an orthophoto texture exported from QGIS. Includes a simple fly-through camera.

### Features
* Terrain from QGIS RAW height data
* Orthophoto material
* MoveCamera script for navigation: WASD + mouse look
* Cursor lock on Play, Esc to release

### Requirements
* Unity 2022.x or newer
* QGIS (for exporting heightmap + orthophoto)

### Controls
* W/S – forward/back
* A/D – left/right
* Mouse – look around
* Esc – unlock cursor

### Quick Start
- Clone the repo and open it in Unity.
- Open the provided sample scene.
- Ensure Main Camera has the MoveCamera script attached.
- Press Play and explore.

### Data & Attribution
Contains data from the **National Land Survey of Finland (NLS)** open datasets:
- **Height data**
- **Orthophotos**

Source: [NLS MapSite – Download geospatial data](https://asiointi.maanmittauslaitos.fi/karttapaikka/tiedostopalvelu)  
License: **Creative Commons Attribution 4.0 (CC BY 4.0)**  
*“Contains data from the National Land Survey of Finland (NLS) Orthophotos and Height data, downloaded 08/2025.”*
