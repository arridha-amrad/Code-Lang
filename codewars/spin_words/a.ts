//  2
const spinWords = (words: string) => {
  return words
    .split(" ")
    .map((txt, i) => (txt.length >= 5 ? txt.split("").reverse().join("") : txt))
    .join(" ");
};

// 1
// const spinWords = (text: string) => {
//   let arrWords = text.split(" ");
//   const reverse = (text: string) => {
//     let result = "";
//     for (let i = 0; i < text.length; i++) {
//       result += text[text.length - 1 - i];
//     }
//     return result;
//   };
//   for (let i = 0; i < arrWords.length; i++) {
//     if (arrWords[i].length >= 5) {
//       arrWords[i] = reverse(arrWords[i]);
//     }
//   }
//   return arrWords.join(" ");
// };

// TEST
console.log(spinWords("Hey fellow warriors") === "Hey wollef sroirraw");
console.log(spinWords("This is a test") === "This is a test");
console.log(spinWords("This is another test") === "This is rehtona test");
