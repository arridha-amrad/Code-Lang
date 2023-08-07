def spin_words(words: str) -> str:
    arrWords = words.split(" ")
    for idx, word in enumerate(arrWords):
        if (len(word) >= 5):
            arrWords[idx] = word[::-1]
    return " ".join(arrWords)


# spin_words("hello world")
print(spin_words("Hey fellow warriors") == "Hey wollef sroirraw")
print(spin_words("This is a test") == "This is a test")
print(spin_words("This is another test") == "This is rehtona test")
