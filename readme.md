## 📚 Address Book Program

This repository implements an **Address Book System** in **C#** using **Object-Oriented Programming (OOP) principles**. Each feature (Use Case) is developed in a **separate branch** and later merged into `main`.

Each **Use Case (UC1 - UC12)** is implemented in its respective branch. The `dev` branch contains the overall **project structure**, and new features are merged from use case branches after completion.

---

## 📌 Use Cases Implemented

### 🔹 **Start: Initialize the Application** (`dev` branch)
- Display `"Welcome to Address Book Program"` in `AddressBookMain` class.
- Set up the basic project structure.

### 🔹 **UC1: Create a Contact in Address Book** (`UC1` branch)
- Create a `ContactPerson` class with the following fields:
  - **First Name, Last Name, Address, City, State, ZIP, Phone, Email**
- Use console input to create new contacts.

### 🔹 **UC2: Add a New Contact in Address Book** (`UC2` branch)
- Use `Console` to input details from `AddressBookMain` class.
- Implement Object-Oriented Concepts for managing relationships between `AddressBook` and `ContactPerson`.

### 🔹 **UC3: Edit an Existing Contact** (`UC3` branch)
- Search and edit a contact using the person's name.

### 🔹 **UC4: Delete a Contact** (`UC4` branch)
- Remove a contact by searching for their name.

### 🔹 **UC5: Add Multiple Contacts** (`UC5` branch)
- Allow adding multiple contacts using a collection (`List`).

### 🔹 **UC6: Multiple Address Books** (`UC6` branch)
- Allow multiple Address Books, each with a unique name.
- Use a `Dictionary` to map Address Book names to contacts.

### 🔹 **UC7: Prevent Duplicate Entries** (`UC7` branch)
- Ensure no duplicate entry for the same person in an Address Book.
- Override `Equals()` to check for duplicates.

### 🔹 **UC8: Search Persons by City or State** (`UC8` branch)
- Search for contacts across multiple Address Books by City/State.

### 🔹 **UC9: View Persons by City or State** (`UC9` branch)
- Maintain a dictionary mapping **City → Persons** and **State → Persons**.

### 🔹 **UC10: Count Contacts by City or State** (`UC10` branch)
- Display count of persons in a given City/State.

### 🔹 **UC11: Sort the entries in address book** (`UC11` branch)
- Display the entries alphabetically by person's name.

### 🔹 **UC12: Sort the entries in address book** (`UC12` branch)
- Display the entries alphabetically by city,state and zip.

---

## 🛠️ Development & Contribution Guidelines

### 1️⃣ **Branching Strategy:**
- Work on **feature branches** (`UC1`, `UC2`, ... `UC12`).
- Merge changes into `dev` before integrating into `main`.

### 2️⃣ **Coding Standards:**
✔ Follow **C# naming conventions**.
✔ Maintain **proper indentation** and **code hygiene**.
✔ Ensure **commit messages** are meaningful.

### 3️⃣ **Git Workflow:**
```sh
# Clone the repository
git clone <repo-url>
cd AddressBook

# Switch to a new feature branch
git checkout -b UC1

# After implementing the feature
git add .
git commit -m "Implemented UC1: Create Contact"

# Push to remote
git push origin UC1
```

### 4️⃣ **Review Process:**
- Every Use Case will be **reviewed before merging** into `main`.
- **Code Quality, Naming Conventions, and Version History** will be checked.

---