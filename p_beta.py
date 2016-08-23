#!/usr/bin/python


def main():
	try:
		
		def inicio1():
			while True:
				print ('''
Only works with the word test

1) Decode 
2) Encode

			''')

				opcion0 = raw_input("\033[1;36m9Dot > \033[1;m")
			
				while opcion0 == "1":
					print ('Type what you want yo decode')
					
					print (' ')
				while opcion0 == "2":
					print ('Type what you want to encode')
					
					print (' ')
		inicio1()
	except KeyboardInterrupt:
		print ("Shutdown requested...Goodbye...")

if __name__ == "__main__":
    main()
