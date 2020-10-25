# FriendlyFireRoundEnd
Turns friendly fire on when the round ends. Will not do anything if you have friendly fired enabled.

## Important Information
To prevent false bans from the main game anti-friendly fire system please set these configs
```
ff_detector_round_enabled: false
ff_detector_life_enabled: false
ff_detector_window_enabled: false
ff_detector_spawn_enabled: false
```

## Install Instructions.

Put FriendlyFireRoundEnd.dll under the release tab into sm_plugins folder.


## Config Options.
| Config Option              | Value Type      | Default Value | Description |
|   :---:                    |     :---:       |    :---:      |    :---:    |
| ffre_disable               | Boolean         | False         | Disables this entire plugin.   |

## Commands

| Command(s)                 | Value Type      | Description                              |
|   :---:                    |     :---:       |    :---:                                 |
| ffre_version               | N/A             | Get the version of this plugin           |
| ffre_disable               | N/A             | Disables this entire plugin.    |