# HW4
## Devlog


The view part of this project would be the UI, and the controll would be the PointDetector. I had the PointDetector script attached to the collider on the edge of the pipes, which would invoke the event onScore, which allowed other classes, such as the UI script to access it. My Locator class would be the singleton, which locates the player, and also checks itself to make sure that there's only one locator. This way, I can handle collisions with the pipes, and the scoring system without every script having to have a reference to the player. Because it was decoupled like this, while I was coding, if something wasn't working or if I hadn't written something yet, I could handle each part of it separately without having to jump between scripts as often. 
## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [2D cartoon birds pack](https://assetstore.unity.com/packages/2d/characters/2d-cartoon-birds-pack-149167)-player sprite
- [Jet Cara](https://assetstore.unity.com/packages/templates/packs/jet-kara-72267)-pipe sprites