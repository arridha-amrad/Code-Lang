class User:
    _name: str
    _age: int
    __isMarried: bool

    def __init__(self, name: str, age: int, isMarried: bool = False) -> None:
        self._name = name
        self._age = age
        self.__isMarried = isMarried

    def greet(self) -> str:
        return f"Hi I'm {self._name}."

    def __str__(self) -> str:
        status = "status: married" if self.__isMarried else ""
        return f"name: {self._name} age: {self._age} {status}"


class Student(User):
    def __init__(self, data: User, school: str) -> None:
        super().__init__(data._name, data._age)
        self.school = school

    def __str__(self) -> str:
        word = super().__str__()
        return f"{word} pendidikan: {self.school}"


u1 = User("ari", 28)
s1 = Student(u1, "kuliah")

# print(u1.greet())
print(u1)

print(s1.greet())
print(s1)
