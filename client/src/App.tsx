
import './App.css'
import {useEffect, useState} from "react";

export interface Product {
  productName: string;
}

function App() {

  const [products, setProducts] = useState<Product[]>([]);
  const [newProductName, setNewProductName] = useState("");

  useEffect(() => {
    fetch('http://localhost:5000/api/products').then(httpresponse => {
      if(httpresponse.ok) {
        httpresponse.json().then(body => {
          setProducts(body)
        })
      }
    })

  }, [])

  return (
    <>
      {
        products.map(p => (
            <div key={p.productName}>{JSON.stringify(p)}</div>
        ))
      }
      <input value={newProductName} onChange={e => setNewProductName(e.target.value)} />
      <button onClick={createProduct}>create new product</button>
    </>
  )

  function createProduct() {
    fetch('http://localhost:5000/api/products', {
      method: 'POST',
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        productName: newProductName
      })
    }).then(httpresponse => {
      if (httpresponse.ok) {
        httpresponse.json().then(body => {
          setProducts([...products, body])
        })
      } else {
        console.error("NOOOOOOOOO")
      }
    })
  }
}

export default App
