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
    weight REAL CHECK(weight >= 0),
    FOREIGN KEY (id) REFERENCES Person(id)
);

CREATE TABLE Logs (
    id INTEGER,
    date DATE,
    serving_size REAL CHECK(serving_size >= 0),
    food_name TEXT,
    protein REAL CHECK(protein >= 0),
    carbo REAL CHECK(carbo >= 0),
    fat REAL CHECK(fat >= 0),
    FOREIGN KEY (id) REFERENCES Person(id)
);
