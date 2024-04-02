// A collection expression can include other collections if prefixed by the .. (spread) operator:

string[] primaryLightColors = ["Red", "Green", "Blue"];
List<string> primaryPigments = ["Magenta", "Cyan", "Yellow"];

HashSet<string> allColors = [.. primaryLightColors, .. primaryPigments, "Black", "White"];
