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
					decode = raw_input('Decode >')
					print (' ')
					if "111010010111110111011010110111010010" in decode:
						decode = "test"
					print decode
					print (' ')
				while opcion0 == "2":
					print ('Type what you want to encode')
					encode = raw_input('Encode >')
					print (' ')
					if "test" in encode:
						encode = "111010010111110111011010110111010010"
					print encode
					print (' ')
		inicio1()
	except KeyboardInterrupt:
		print ("Shutdown requested...Goodbye...")
	except Exception:
		traceback.print_exc(file=sys.stdout)
	sys.exit(0)

if __name__ == "__main__":
    main()
