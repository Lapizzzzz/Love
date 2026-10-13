# in-class-activities
## Devlogs
### W1
The camera stays in place while the Cat moves, instead of following it. This is because the Camera is no longer a child of the Cat so it no longer follows its movement or rotation.

[Play W1 In-Class Activity on itch.io](https://lapizz.itch.io/w1-inclass-gdim31)

### W2
1. The r, g, and b variables are floats because color values need decimals. Ints only store whole numbers, bools store true or false, and strings store text.
2. The bounce count is an int because each bounce adds one whole number. It does not need decimals, true or false values, or text.
3. The error showed that a semicolon was missing at the end of the statement. I fixed it by adding a semicolon after `g -= 0.1f`.

### W3

Table #: 3

#### Activity 1: Methods Discussion

1. `GetResponse`
   - Parameters: `int friendshipLevel`, `bool knowsSecret`
   - Return type: `string`, the character's dialogue response.

2. `SetLightDimness`
   - Parameter: `float sanityLevel` (0-100)
   - Return type: `void`, because the method changes the light directly.

3. `DidPlayerHitBeat`
   - Parameter: `float keyPressTime`
   - Return type: `bool`, indicating whether the player hit the beat accurately.

#### Activity 2: Components & Classes Metaphor

A class is like a blueprint for a house. The blueprint describes what a house can have and do, but it is not itself a house in the scene. A Component is like one actual house built from that blueprint. Member variables are the house's traits, such as its color or number of floors. Methods are the actions it can perform, such as opening a door or turning on a light. Multiple houses can be built from the same blueprint, just as multiple Components can be created from one class.

#### Activity 3: Brightness

The balls get extremely bright because their color values are multiplied by 1.5 each time they collide above the speed threshold. The values keep increasing without a limit and can go above 1, which makes the balls look very bright.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
