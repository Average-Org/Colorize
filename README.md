# Colorize - TShock Color Formatting Tool

## Introduction

Colorize is a simple, yet helpful, color formatting tool designed for use with TShock. It provides a range of methods to format text with colors, gradients, and item icons in C#. This library is tailored to make the life of plugin developers easier by offering a straightforward way to beautify their messages and outputs.

## Features

- **Easy Color Formatting**: Utilize C# methods to format your text with colors effortlessly.
- **Gradient Text**: Create eye-catching messages with gradient color schemes.
- **Item Icon Display**: Easily display Terraria item icons using item IDs.
- **Short-Formed Extension Methods**: Quick and efficient extension methods for `TSPlayer` to streamline your coding process.

## Installation

You can either add this as a NuGet package or create an assembly reference to the .DLL in the releases.

**NOTE** - You need to put `Colorize.dll` in the bin folder of all TShock instances that utilize this library.

## Usage

### Formatting Text with Colors
![image](https://github.com/Average-Org/Colorize/assets/24498058/5c2884b8-dbf7-45b8-b8f2-69392d0b783e)

```csharp
      Commands.ChatCommands.Add(new Command("test", (x) => {
          x.Player.Msg($"" +
              $"{TextColor("<Prefix> ", Color.LightBlue)}" +    
              $"{TextColor("This is an ", Color.LightGreen)}" +  
              $"{TextColor("oddly colored ", Color.Magenta)}" +  
              $"{TextColor("chat message!", Color.Cyan)}");    
      }, "test"));
```

Use ```TextColor(string, Color)``` and append it to your string

### Creating Gradient Text
![image](https://github.com/Average-Org/Colorize/assets/24498058/5b76488e-8b0b-4207-b150-7383fd14dd4e)

```csharp
      Commands.ChatCommands.Add(new Command("testgradient", (x) =>
      {
          x.Player.MsgGradient("Woaaah this text is gradient-ed!", Color.LightGreen, Color.OrangeRed);
      }, "testgradient")); // you can also use TextGradient for changing individual string gradients
```

### Displaying Item Icons
![image](https://github.com/Average-Org/Colorize/assets/24498058/cc71bba9-faef-4414-9ef7-96e590ceba5f)

```csharp
      Commands.ChatCommands.Add(new Command("testitem", (x) =>
      {
          x.Player.Msg(ItemIcon(ItemID.AaronsBreastplate) + ItemIcon(ItemID.CopperShortsword) + ItemIcon(ItemID.SlimeCandle));
      }, "testitem"));
```

### Using Short-Formed Extension Methods

By adding the ```using static Colorize.Tools;``` directive, you can use the following:
```csharp
TextColor(string, Color); // returns a Terraria-formatted text w/ color applied
TextGradient(string, Color, otherColor); // returns a Terraria-formatted gradient text
ItemIcon(ItemID); // returns the desired Item ID as a Terraria-formatted icon text

TSPlayer.Error("text"); // sends the player a red message
TSPlayer.Info("text"); // sends the player a yellow message
TSPlayer.Msg("txt"); // sends the player a white message
TSPlayer.Msg("text", Color.Blue); // sends the player a colored message
TSPlayer.MsgGradient("text", Color.Blue, Color.LightBlue); sends the player a gradiented message
```

Suggest more you'd like to see implemented!
