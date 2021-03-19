## ファイル内の文字列を置換
`./replacestr.awk replace.txt`

```awk
awk -i inplace -v inplace::suffix=.bak_$(date +%Y%m%d_%H%M%S) '
{
gsub("-","/")
gsub("1","2")
print $0
}
' $1
```
