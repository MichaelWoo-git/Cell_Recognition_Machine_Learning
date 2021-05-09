ls $1 > s1.txt
while read file; do 
git add "$1$file"
done < s1.txt
git commit -m "$1"
git push
rm s1.txt
