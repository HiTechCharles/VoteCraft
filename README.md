# VoteCraft

[![.NET Framework 4.8.1](https://img.shields.io/badge/.NET%20Framework-4.8.1-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![License](https://img.shields.io/github/license/HiTechCharles/VoteCraft)](LICENSE)

A Windows Forms desktop application designed to streamline the process of voting for Minecraft servers across multiple server listing websites. VoteCraft helps players track their voting progress and estimate when they'll reach their next vote milestone or server rank.

## Features

- **Quick Access to Voting Sites**: One-click access to multiple Minecraft server listing websites
- **Vote Progress Tracking**: Track your total votes and progress toward your next goal
- **Goal Projection**: Automatically calculates the estimated date to reach your vote target
- **Auto-Save**: Automatically saves your voting statistics
- **Username Clipboard**: Automatically copies your Minecraft username to clipboard for easy pasting
- **Visual Feedback**: Buttons change color when clicked to indicate visited sites

## Supported Voting Sites

VoteCraft provides direct links to the following Minecraft server listing sites:

1. **Top MineCraft Servers** - topminecraftservers.org
2. **MineCraft Servers.org** - minecraftservers.org
3. **MineCraft Server List** - minecraft-server-list.com
4. **Minecraft MP** - minecraft-mp.com
5. **Minecraft Buzz** - minecraft.buzz
6. **MC Java Wiki** - Quick reference to Minecraft Java Edition wiki

## Screenshots

![VoteCraft Application](docs/screenshot.png)
*Screenshot placeholder - Add your own screenshot to `docs/screenshot.png`*

## Installation

### Prerequisites

- Windows OS (7, 8, 10, 11)
- .NET Framework 4.8.1 or higher

### Download & Run

1. Download the latest release from the [Releases](https://github.com/HiTechCharles/VoteCraft/releases) page
2. Extract the ZIP file to your preferred location
3. Run `VoteCraft.exe`

### Build from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/HiTechCharles/VoteCraft.git
   ```

2. Open `VoteCraft.sln` in Visual Studio 2022 or later

3. Build the solution:
   - Press `Ctrl+Shift+B` or
   - Go to **Build** → **Build Solution**

4. Run the application:
   - Press `F5` or
   - Go to **Debug** → **Start Debugging**

## Usage

1. **Launch VoteCraft**: Start the application
2. **Your Username**: The application automatically copies "HiTechCharles" to your clipboard (customize in code if needed)
3. **Click Voting Buttons**: Click each button to open the voting site in your default browser
4. **Enter Votes**: Paste your username and vote on each site
5. **Track Progress**: 
   - Update "Vote Total" with your current vote count
   - Set "Next Level" to your target vote count
   - The app displays days remaining and projected completion date
6. **Automatic Saving**: Your statistics are automatically saved periodically

## Configuration

### Customizing Your Minecraft Username

To change the default username, edit `Form1.cs`:

```csharp
private const string MinecraftUsername = "YourMinecraftUsername";
```

### Adjusting Votes Per Day

The application assumes 5 votes per day. To modify this:

```csharp
private const decimal VotesPerDay = 5m;
```

### Data Storage

Vote statistics are saved to:
```
%OneDriveConsumer%\documents\VoteCraft\VoteStats.txt
```
Or if OneDrive is not available:
```
%UserProfile%\Documents\VoteCraft\VoteStats.txt
```

## Development

### Project Structure

```
VoteCraft/
├── Form1.cs              # Main application logic
├── Form1.Designer.cs     # UI designer code
├── Program.cs            # Application entry point
├── VoteCraft.csproj      # Project configuration
└── Properties/
	├── AssemblyInfo.cs   # Assembly metadata
	└── Resources/        # Application resources
```

### Key Technologies

- **Language**: C# 7.3
- **Framework**: .NET Framework 4.8.1
- **UI Framework**: Windows Forms
- **IDE**: Visual Studio 2022+

## Contributing

Contributions are welcome! Here's how you can help:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Ideas for Contributions

- Add more voting sites
- Implement reminder notifications
- Add dark mode theme
- Create a vote history/calendar view
- Multi-language support

## Version History

- **9.27.0.0** (Current) - Latest stable release

## License

This project is licensed under the terms specified in the repository. See the [LICENSE](LICENSE) file for details.

## Author

**HiTechCharles**
- GitHub: [@HiTechCharles](https://github.com/HiTechCharles)

## Acknowledgments

- Thanks to all Minecraft server listing sites for providing voting platforms
- Built with Windows Forms and .NET Framework

## Support

If you encounter any issues or have suggestions:

- Open an [Issue](https://github.com/HiTechCharles/VoteCraft/issues)
- Submit a [Pull Request](https://github.com/HiTechCharles/VoteCraft/pulls)

---

**Note**: This application is designed for personal use to streamline voting for Minecraft servers. Please respect the voting rules and limitations of each server listing site.
