CREATE TABLE Person (
    id INTEGER PRIMARY KEY,
    username TEXT,
    password TEXT
);

CREATE TABLE PersonData (
    id INTEGER,
    first_name TEXT CHECK(first_name GLOB '[a-zA-Z]*'),
    last_name TEXT CHECK(last_name GLOB '[a-zA-Z]*'),
    age INTEGER CHECK(age >= 0),
    gender TEXT CHECK(gender IN ('M', 'F')),
    height INTEGER CHECK(height >= 0),
    FOREIGN KEY (id) REFERENCES Person(id)
);

CREATE TABLE Weight (
    id INTEGER,
    date DATE,
    weight INTEGER CHECK(weight >= 0),
    FOREIGN KEY (id) REFERENCES Person(id)
);

CREATE TABLE Logs (
    id INTEGER,
    date DATE,
    type TEXT CHECK(type IN ('snack', 'breakfast', 'lunch', 'dinner')),
    food_name TEXT,
    protein INTEGER CHECK(protein >= 0),
    carbo INTEGER CHECK(carbo >= 0),
    fat INTEGER CHECK(fat >= 0),
    FOREIGN KEY (id) REFERENCES Person(id)
);
