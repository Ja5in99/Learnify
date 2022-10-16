import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import { useEffect } from "react";
import agent from "../actions/agent";
import Checkout from "../components/Checkout";
import { setBasket } from "../redux/slice/basketSlice";
import { useAppDispatch } from "../redux/store/configureStore";

const stripePromise = loadStripe(
  "pk_test_51LmMAoLanl2pWuLm1x6GoAEXBd2Tk4YRI0IcFR18Ep4QXeAagAMC9ByMYjvgVpiutNUTKVgT8SkJA2h32YU4amiJ00fcjWUyza"
);

export default function CheckoutWrapper() {
  const dispatch = useAppDispatch();

  useEffect(() => {
    agent.Payments.paymentIntent()
      .then((basket) => dispatch(setBasket(basket)))
      .catch((error) => console.log(error));
  }, [dispatch]);

  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
