# TSPUD Modding Template Project

This repo contains a template project to get you started with TSPUD modding.

## Setup

1. Clone this project somewhere onto your computer.
2. Go to your game's install directory (On steam: Right click => View local files), go to `The Stanley Parable Ultra Deluxe_Data\Managed` and copy all `dll` files from there to the `Libraries` folder.
3. Inject Melonloader (See here, follow the [Automated Install](https://melonwiki.xyz/#/?id=automated-installation) and select TSP: UD as your game).
4. Go to the game directory again, and copy the `MelonLoader.dll` and `0Harmony.dll` `dll`s from the  `Melonloader` directory to `Libraries`.
4. Open the project in your IDE.
4. Expand `Solution Items` and edit the `InstallMods` project. Go to `Build` > `Events`. Make sure the post build Event points to your install location. (This project simply copies all your mods to the game whenever you compile, so that you can simply compile and reboot the game).
4. Start Modding! (You might want to look at [Hyblocker's TSP: UD mods repo for code examples.](https://github.com/hyblocker/TSPUD-Mods))

## License

This repo is licensed under no real license. You are free to change the license to whatever you deem fit, however I am not responsible for anything related with this project and its derivatives.