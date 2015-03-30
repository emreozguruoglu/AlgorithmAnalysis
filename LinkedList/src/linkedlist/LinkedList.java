/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package linkedlist;

/**
 *
 * @author BM
 */
public class LinkedList {
        // Node'un head kısmı referans edildi
	private Node head;
	private int listCount;
	
	// LinkedList Yapıcısı
	public LinkedList()
	{
		// Bu bir boş listedir, Data'sız bir node'u referans olarak head'e veriyoruz
		head = new Node(null);
		listCount = 0;
	}
        
         public static void main(String [] args)
	{
            LinkedList l1=new LinkedList();
            l1.add(1);
            l1.add(2);
            l1.add(3);
            l1.add(4);
            l1.remove(2);
            System.out.println("Liste = " + l1);
                
	}
	
	public void add(Object data)
	// Bu listenin sonuna yolluyoruz.
	{
		Node gecici = new Node(data);
		Node current = head;
		// starting at the head node, crawl to the end of the list
		while(current.getNext() != null)
		{
			current = current.getNext();
		}
		// the last node's "next" reference set to our new node
		current.setNext(gecici);
		listCount++;// increment the number of elements variable
	}
	
	public void add(Object data, int index)
	// post: inserts the specified element at the specified position in this list.
	{
		Node gecici = new Node(data);
		Node current = head;
		// crawl to the requested index or the last element in the list,
		// whichever comes first
		for(int i = 1; i < index && current.getNext() != null; i++)
		{
			current = current.getNext();
		}
	
		gecici.setNext(current.getNext());
		
		current.setNext(gecici);
		listCount++;
	}
	
	public Object get(int index)
	
	{
		// İndex en az 1 veya daha çok olmalı
		if(index <= 0)
			return null;
		
		Node current = head.getNext();
		for(int i = 1; i < index; i++)
		{
			if(current.getNext() == null)
				return null;
			
			current = current.getNext();
		}
		return current.getData();
	}
	
	public boolean remove(int index)
	// Spesifik pozisyonundan elemanı bu listeden siliyoruz.
	{
		// Eğer Listenin boyundan büyükse çık.
		if(index < 1 || index > size())
			return false;
		
		Node current = head;
		for(int i = 1; i < index; i++)
		{
			if(current.getNext() == null)
				return false;
			
			current = current.getNext();
		}
		current.setNext(current.getNext().getNext());
		listCount--; // Değişken elemanların sayısını azaltma
		return true;
	}
	
	public int size()
	//Listedeki eleman sayisini geri döndermektedir.
	{
		return listCount;
	}
	
	public String toString()
	{
		Node current = head.getNext();
		String output = "";
		while(current != null)
		{
			output += "[" + current.getData().toString() + "]";
			current = current.getNext();
		}
		return output;
	}
	
	private class Node
	{
		// reference to the next node in the chain,
		// or null if there isn't one.
		Node next;
		// Veri bu node'da tutulmaktadır.
		// İhtiyac duydugunuz tipte olabilir.
		Object data;
		

		// Node yapıcısı
		public Node(Object _data)
		{
			next = null;
			data = _data;
		}
		
		
		public Node(Object _data, Node _next)
		{
			next = _next;
			data = _data;
		}
                
		public Object getData()
		{
			return data;
		}
		
		public void setData(Object _data)
		{
			data = _data;
		}
		
		public Node getNext()
		{
			return next;
		}
		
		public void setNext(Node _next)
		{
			next = _next;
		}
                
               
        }
}
