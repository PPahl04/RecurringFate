# Overview

This Windows desktop application “Recurring Fate” is used to create entries and view the days between existing entries.

![Overview of entries](images/EntriesTab.png "Entry Tab").

These entries are kept in a list and displayed in an overview. In this overview, you can view the days between those entries.

![Create entry](images/CreateEntryTab.png "Create Tab").

Each entry requires the following data:
- Title
- Description
- Date

In the settings, you can save the created entries in a JSON file and reload them. Created entries can also be edited or deleted via the “Entry” tab.

---
## Functions

- Creating entries
- Editing existing entries
- Saving data to a JSON file
- Loading valid JSON files to load existing entries
- Deleting entries

---

## Installation

1. Clone repo:
   ```bash
   git clone https://github.com/PPahl04/RecurringFate.git
   cd "Recurring Fate"

2. Start program
    ```bash
    dotnet build
    "Recurring Fate\bin\Debug\net8.0-windows\Recurring Fate.exe"
