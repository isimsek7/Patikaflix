# Patikaflix Console Application

Patikaflix is a console application that allows users to add TV shows (Dizi) to a list and filter them based on specific genres. This application demonstrates basic C# concepts such as loops, conditionals, error handling, and LINQ queries.

## Features

- Add TV shows with details like name, production year, genre, release date, director, and first platform released.
- Option to add multiple TV shows in a single session.
- Filter shows based on their genre using LINQ.
- Display filtered TV shows sorted alphabetically by their name and director.


## Usage

1. **Run the application**:
    ```bash
    dotnet run
    ```

2. **Add TV shows**:
    - Enter details for each TV show when prompted.
    - After entering the details for one show, you will be asked if you want to add another.
    - Enter `E` to add another show or `H` to stop adding shows.

3. **Filter and display shows**:
    - The application automatically filters shows with the genre "Komedi" (Comedy) and displays them sorted by name and director.
