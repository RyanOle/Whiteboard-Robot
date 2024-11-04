with open("/home/pqtcc/post.txt", "r") as file:
   post = file.read()

post = list(post)

for i in range(len(post)):
   print(post[i])
