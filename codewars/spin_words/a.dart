void main() {
  // String spinWords(String words) {
  //   return words
  //       .split(" ")
  //       .map((word) =>
  //           word.length >= 5 ? word.split("").reversed.join("") : word)
  //       .join(" ");
  // }

  String spinWords(String words) {
    List<String> arrWords = words.split(" ");
    for (int i = 0; i < arrWords.length; i++) {
      if (arrWords[i].length >= 5) {
        arrWords[i] = arrWords[i].split("").reversed.join("");
      }
    }
    return arrWords.join(" ");
  }

  print(spinWords("Hey fellow warriors") == "Hey wollef sroirraw");
  print(spinWords("This is a test") == "This is a test");
  print(spinWords("This is another test") == "This is rehtona test");
}
