# 🌦️ Live Weather

**Live Weather** is a dynamic weather forecasting web application that displays real-time weather conditions based on user search. The app provides weather updates for any city worldwide, with a clean and modern interface that adapts dynamically based on the climate conditions.

![LiveWeather Demo](https://media0.giphy.com/media/v1.Y2lkPTc5MGI3NjExaHVvcDNkbTE4MXU4bTQ0OWUybzdmbGN0N3N6OXBkYjhkZmdsazBvZCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/Vmcc0RwE5JxgOvdSOe/giphy.webp)  

## 🌟 Features

- 🌍 **Live Weather Data**: Fetch real-time weather data using the LiveWeather API.
- 🎨 **Dynamic Background**: The background changes based on the current weather (e.g., clear skies, rain, snow).
- 🔍 **City Search**: Easily search for weather conditions by entering the city name.
- 📱 **Responsive Design**: Works across multiple devices, providing a seamless experience on both desktop and mobile.
- 💻 **User-Friendly Interface**: Clean, minimalistic design with intuitive controls.

## 🚀 Getting Started

Follow these instructions to set up and run the Live Weather app on your local machine.

### Prerequisites

- ⚙️ [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- 🔑 [LiveWeather API Key](https://LiveWeathermap.org/api)
- 🖥️ [Visual Studio Code](https://code.visualstudio.com/) (for development)


### Installation

1. **🔍 Open Visual Studio Code.**
   - Your trusty IDE is waiting!

2. **🔗 Clone the Repository:**
   - Bring the Live Weather project to your local machine with:
    ```bash
    git clone https://github.com/dilanmelvin/LiveWeather.git
    cd LiveWeather
    ```

3. **📦 Install Dependencies:**
   - Ensure you have all the required packages ready to go:
    ```bash
    dotnet restore
    ```

4. **🔑 Set Up Your API Key:**
   - Navigate to `appsettings.json` in the `output/` directory.
   - Replace the placeholder with your **LiveWeather API Key**:
    ```json
    {
      "LiveWeatherApiKey": "YOUR_API_KEY_HERE"
    }
    ```

5. **⚙️ Build and Run the Application:**
   - Time to bring your weather app to life:
    ```bash
    dotnet build
    dotnet run
    ```

6. **🌐 View Your Application:**
   - Open your favorite browser and navigate to:
   - [http://localhost:5000](http://localhost:5000) to see the magic unfold!
---

### 🔧 Project Structure

```bash
LiveWeather/
├── Controllers/         # Handles the weather fetching logic
├── Services/            # WeatherService.cs, API logic
├── wwwroot/             # Static files (CSS, Images)
├── appsettings.json     # Configuration file
├── Program.cs           # Entry point of the application
└── LiveWeather.sln      # Solution file
```

### Key Components

- **`WeatherService.cs`**: Contains the logic to call the LiveWeather API and process the response.
- **`wwwroot/`**: Contains static files like CSS, images, and the favicon.
- **`appsettings.json`**: Stores the LiveWeather API key and other configuration details.

## 🌐 API Integration

Live Weather leverages the **LiveWeather API** to fetch live weather data. You can find more information on the [LiveWeather API documentation](https://LiveWeathermap.org/api).

## 🎨 UI/UX Design

- The design is minimalist and focuses on usability.
- **Dynamic backgrounds** reflect the current weather conditions (e.g., a rainy scene for rainy weather).
- The **search bar** is prominently displayed and allows users to search by pressing "Enter".

## 🛠️ Built With

- **.NET 8.0**
- **LiveWeather API**
- **HTML/CSS**
- **JavaScript**
- **Bootstrap 4**

## 🌍 Deployment

To deploy this project on a live server, ensure that:
1. The LiveWeather API key is set correctly in the `appsettings.json`.
2. All static files are correctly configured and served in the deployment environment.

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Feel free to submit a pull request, report bugs, or suggest new features.

## 💬 Contact

For any questions or feedback, feel free to reach out at:
- **linkedin**: [dilanmelvin](https://linkedin.com/in/t-dilan-melvin)

![LiveWeather Demo](https://media1.giphy.com/media/uXqfbP155Gpj2dP6t6/100.webp?cid=790b7611wjlwn81zixdpsw9mk7bov38vyacbo72fwsii09lk&ep=v1_gifs_search&rid=100.webp&ct=g)  


