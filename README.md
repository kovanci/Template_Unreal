[![](https://img.shields.io/badge/UE%20Version:-5.3-orange?logo=unrealengine)][1]

Unreal Engine template project(C++) for prototyping. Some plugins have been deactivated.

[Recommended Video][2]

### 🔨 Activated Plugins
- [CommonUI][3]
- [GameplayMessageRouter][4]
- [AsyncMixin][5]

### 💿 Installation
- Put project folder in
  ```
  EpicGames/UE_{Version}/Templates
  ```

- Run submodule command in project folder.
  ```
  git submodule update --init
  ```

- Populate correct value for `UE5_DIR` in `vars.bat`.

### 🔥 Example .bat Usages
- Supports default UE Command-Line Arguments.

- 🏷️ Build and Open Editor

  ```
  .\build && .\editor
  ```

- 🏷️ Build and Open Editor (attach Log Console)

  ```
  .\build && .\editor -log
  ```

- 🏷️ Launch playable game instance without loading up the editor

  ```
  .\editor -game -log -windowed -resx=1280 -resy=720
  ```

[1]: https://www.unrealengine.com/en-US/download
[2]: https://www.youtube.com/watch?v=94FvzO1HVzY
[3]: https://docs.unrealengine.com/5.3/en-US/common-ui-plugin-for-advanced-user-interfaces-in-unreal-engine/
[4]: https://github.com/kovanci/GameplayMessageRouter
[5]: https://github.com/kovanci/AsyncMixin
